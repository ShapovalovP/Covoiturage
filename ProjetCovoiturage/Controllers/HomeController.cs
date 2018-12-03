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
        [AllowAnonymous]
        public ActionResult PageFR()
        {
            Session["Culture"] = new CultureInfo("fr");
            return Redirect(Request.UrlReferrer.ToString());
        }

        [AllowAnonymous]
        public ActionResult PageEN()
        {
            Session["Culture"] = new CultureInfo("en");
            return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Chauffeur")]
        public ActionResult About()
        {
            return View();
        }
        [Authorize(Roles = "Client")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}