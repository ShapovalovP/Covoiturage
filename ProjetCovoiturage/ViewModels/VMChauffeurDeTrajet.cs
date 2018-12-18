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
        [Display(Name = "NumberRides", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public string nbTrajets { get; set; }

        [Display(Name = "NumberMileage", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public string nbKilometres { get; set; }

        [Display(Name = "AverageRating", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public string moyenneApreci { get; set; }


        [Display(Name = "AveragePunctuality", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public decimal moyennePonctualite { get; set; }
        [Display(Name = "AverageSecurity", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public decimal moyenneSecurite { get; set; }
        [Display(Name = "AverageComfort", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public decimal moyenneConfort { get; set; }
        [Display(Name = "AverageComfort", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public decimal moyenneCourtoisie { get; set; }
        [Display(Name = "AverageReliability", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public decimal moyenneFiabilite { get; set; }


        [Display(Name = "DepartureCity", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public string VilleDepart { get; set; }

        [Display(Name = "StartingPoint", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public string PointDepart { get; set; }

        [Display(Name = "ArrivalPoint", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public string PointArrivee { get; set; }

        [Display(Name = "Price", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public int Prix { get; set; }

        [Display(Name = "ArrivalCity", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public string VilleDestination { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "DepartureHour", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public DateTime HeureDepart { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "ArrivalHour", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public DateTime HeureArrivee { get; set; }

        [Display(Name = "NumberSeatsLeft", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public int NbPassagers { get; set; }

        [Display(Name = "Mileage", ResourceType = typeof(Resources.Views.VMChauffeurDeTrajet))]
        public int Kilometrage { get; set; }
        public Chauffeur Chauffeur { get; set; }
    }
}