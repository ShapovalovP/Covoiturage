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
        [Display(Name = "HeurDepart", ResourceType = typeof(Resources.Models.Trajet))]
        public DateTime calendarD { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,
 DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "HeurArrive", ResourceType = typeof(Resources.Models.Trajet))]
        public DateTime calendarF { get; set; }


        [Display(Name = "VilleDepart", ResourceType = typeof(Resources.Models.Trajet))]

        public string villeDepart { get; set; }

        [Display(Name = "VilleDestination", ResourceType = typeof(Resources.Models.Trajet))]

        public string villeDestination { get; set; }

        public List<Trajet> listTraj { get; set; }

        [Display(Name = "PointDepart", ResourceType = typeof(Resources.Models.Trajet))]

        public string PointDepart { get; set; }

        [Display(Name = "PointArrive", ResourceType = typeof(Resources.Models.Trajet))]

        public string PointArrive { get; set; }

        [Display(Name = "Prix", ResourceType = typeof(Resources.Models.Trajet))]

        public string Prix { get; set; }

        [Display(Name = "Kilometrage", ResourceType = typeof(Resources.Models.Trajet))]
        public int Kilometrage { get; set; }

        [Display(Name = "NbPassagers", ResourceType = typeof(Resources.Models.Trajet))]

        public int NbPassagers { get; set; }
    }
}