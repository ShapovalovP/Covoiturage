using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.ViewModels
{
    public class VMChauffeurDeTrajet
    {
        [Display(Name = "NumberRides", ResourceType = typeof(Resources.Models.Trajet))]
        public string nbTrajets { get; set; }

        [Display(Name = "NumberMileage", ResourceType = typeof(Resources.Models.Trajet))]
        public string nbKilometres { get; set; }

        [Display(Name = "AverageRating", ResourceType = typeof(Resources.Models.Trajet))]
        public string moyenneApreci { get; set; }


        [Display(Name = "AveragePunctuality", ResourceType = typeof(Resources.Models.Trajet))]
        public decimal moyennePonctualite { get; set; }
        [Display(Name = "AverageSecurity", ResourceType = typeof(Resources.Models.Trajet))]
        public decimal moyenneSecurite { get; set; }
        [Display(Name = "AverageComfort", ResourceType = typeof(Resources.Models.Trajet))]
        public decimal moyenneConfort { get; set; }
        [Display(Name = "AverageComfort", ResourceType = typeof(Resources.Models.Trajet))]
        public decimal moyenneCourtoisie { get; set; }
        [Display(Name = "AverageReliability", ResourceType = typeof(Resources.Models.Trajet))]
        public decimal moyenneFiabilite { get; set; }


        [Display(Name = "DepartureCity", ResourceType = typeof(Resources.Models.Trajet))]
        public string VilleDepart { get; set; }

        [Display(Name = "StartingPoint", ResourceType = typeof(Resources.Models.Trajet))]
        public string PointDepart { get; set; }

        [Display(Name = "ArrivalPoint", ResourceType = typeof(Resources.Models.Trajet))]
        public string PointArrivee { get; set; }

        [Display(Name = "Price", ResourceType = typeof(Resources.Models.Trajet))]
        public int Prix { get; set; }

        [Display(Name = "ArrivalCity", ResourceType = typeof(Resources.Models.Trajet))]
        public string VilleDestination { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "DepartureHour", ResourceType = typeof(Resources.Models.Trajet))]
        public DateTime HeureDepart { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "ArrivalHour", ResourceType = typeof(Resources.Models.Trajet))]
        public DateTime HeureArrivee { get; set; }

        [Display(Name = "NumberSeatsLeft", ResourceType = typeof(Resources.Models.Trajet))]
        public int NbPassagers { get; set; }

        [Display(Name = "Mileage", ResourceType = typeof(Resources.Models.Trajet))]
        public int Kilometrage { get; set; }
        public Chauffeur Chauffeur { get; set; }
    }
}