using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetCovoiturage.Validations
{
    public class Remove24hValidation : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session != null)
            {


                var idTemp = Convert.ToInt32(filterContext.ActionParameters["id"]);
                ApplicationDbContext bd= new ApplicationDbContext();
               Trajet trajet= bd.Trajets.Where(x => x.Id == idTemp).FirstOrDefault();

                DateTime datedepart = new DateTime(trajet.HeureDepart.Year, trajet.HeureDepart.Month, trajet.HeureDepart.Day, trajet.HeureDepart.Hour, trajet.HeureDepart.Minute, trajet.HeureDepart.Second);
                DateTime dateaujourdhui = DateTime.Now;
                dateaujourdhui = dateaujourdhui.AddDays(1);
                if (dateaujourdhui > datedepart)
                {
                    //filterContext.Controller.TempData["FlashMessage"] = "Impossible de retirer un trajet 24 heure ou moins avant le trajet";
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Trajets", action = "Delete", id = idTemp }));
                    filterContext.Controller.TempData.Add("Error", ProjetCovoiturage.Resources.Models.Validations.Impossible24H);
                }
                base.OnActionExecuting(filterContext);

                //   DateTime datedepart = new DateTime(trajet.DateDepart.Year, trajet.DateDepart.Month, trajet.DateDepart.Day, trajet.HeureDepart.Hour, trajet.HeureDepart.Minute, trajet.HeureDepart.Second);


            }
        }

    }
}
