using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.ViewModels
{
    public class VMFiltreTrajets
    {
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,
DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "DepartureHour", ResourceType = typeof(Resources.Views.VMFiltreTrajets))]
        public DateTime calendarD { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,
 DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "ArrivalHour", ResourceType = typeof(Resources.Views.VMFiltreTrajets))]
        public DateTime calendarF { get; set; }


        [Display(Name = "DepartureCity", ResourceType = typeof(Resources.Views.VMFiltreTrajets))]
        public string villeDepart { get; set; }

        [Display(Name = "ArrivalCity", ResourceType = typeof(Resources.Views.VMFiltreTrajets))]
        public string villeDestination { get; set; }

        public List<Trajet> listTraj { get; set; }

        [Display(Name = "StartingPoint", ResourceType = typeof(Resources.Views.VMFiltreTrajets))]
        public string PointDepart { get; set; }

        [Display(Name = "ArrivalPoint", ResourceType = typeof(Resources.Views.VMFiltreTrajets))]
        public string PointArrivee { get; set; }

        [Display(Name = "Price", ResourceType = typeof(Resources.Views.VMFiltreTrajets))]
        public string Prix { get; set; }

        [Display(Name = "Mileage", ResourceType = typeof(Resources.Views.VMFiltreTrajets))]
        public int Kilometrage { get; set; }

        [Display(Name = "NumberSeatsLeft", ResourceType = typeof(Resources.Views.VMFiltreTrajets))]
        public int NbPassagers { get; set; }
    }
}