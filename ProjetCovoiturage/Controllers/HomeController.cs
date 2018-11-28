using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetCovoiturage.Controllers
{
    [Authorize(Roles = "Chauffeur, Client")]
    public class HomeController : Controller
    {
        public ActionResult PageFR()
        {
            Session["Culture"] = new CultureInfo("fr");
            return RedirectToAction("Index");
        }

        public ActionResult PageEN()
        {
            Session["Culture"] = new CultureInfo("en");
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Chauffeur")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize(Roles = "Client")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}