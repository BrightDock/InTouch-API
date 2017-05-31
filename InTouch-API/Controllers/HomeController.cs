using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InTouch_API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            using (var Db = new InTouch_DBEntities())
            {
                return View("index", Db.Users.ToList());
            }
        }
    }
}
