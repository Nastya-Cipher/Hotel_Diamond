using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel_Diamond.Models;

namespace Hotel_Diamond.Controllers
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
        public ActionResult Autorization()
        {
            return "dsgr";
        }
    }
}