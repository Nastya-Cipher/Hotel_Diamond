using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelDiamond.Models;

namespace HotelDiamond.Controllers
{
    public class HotelController : Controller
    {
        [Authorize]
        public ActionResult Rooms()
        {
            return View();
        }
    }
}