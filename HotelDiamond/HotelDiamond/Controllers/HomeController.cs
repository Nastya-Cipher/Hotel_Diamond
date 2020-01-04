using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelDiamond.Models;
using System.Text.RegularExpressions;

namespace HotelDiamond.Controllers
{
    public class HomeController : Controller
    {
        HotelContext db = new HotelContext();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Autorization()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Autorization(User user)
        {
            return View("Index");
            /* 
             if (Regex.IsMatch(user.Email, pattern, RegexOptions.IgnoreCase)==true)
             {
                 user.TimeBlock = DateTime.Now;
                 db.Users.Add(user);
                 db.SaveChanges();
                 return View("Index");
             }
             else
             {
                 string error = "Вы ввели некоректный Email";
                 return View();
             }*/

        }

        public ActionResult LogIn()
        {
            IEnumerable<User> users = db.Users;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Users = users;
            return View();
        }
    }
}