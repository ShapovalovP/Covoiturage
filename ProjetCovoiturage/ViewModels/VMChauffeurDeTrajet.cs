using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.ViewModels
{
    public class VMChauffeurDeTrajet
    {
        [Display(Name = "nbTrajets", ResourceType = typeof(Resources.Models.Trajet))]
        public string nbTrajets { get; set; }

        [Display(Name = "nbKilometres", ResourceType = typeof(Resources.Models.Trajet))]
        public string nbKilometres { get; set; }

        [Display(Name = "moyenneApreci", ResourceType = typeof(Resources.Models.Trajet))]
        public string moyenneApreci { get; set; }


        [Display(Name = "moyennePonctualite", ResourceType = typeof(Resources.Models.Trajet))]
        public decimal moyennePonctualite { get; set; }
        [Display(Name = "moyenneSecurite", ResourceType = typeof(Resources.Models.Trajet))]
        public decimal moyenneSecurite { get; set; }
        [Display(Name = "moyenneConfort", ResourceType = typeof(Resources.Models.Trajet))]
        public decimal moyenneConfort { get; set; }
        [Display(Name = "moyenneCourtoisie", ResourceType = typeof(Resources.Models.Trajet))]
        public decimal moyenneCourtoisie { get; set; }
        [Display(Name = "moyenneFiabilite", ResourceType = typeof(Resources.Models.Trajet))]
        public decimal moyenneFiabilite { get; set; }


        [Display(Name = "VilleDepart", ResourceType = typeof(Resources.Models.Trajet))]
        public string VilleDepart { get; set; }

        [Display(Name = "PointDepart", ResourceType = typeof(Resources.Models.Trajet))]
        public string PointDepart { get; set; }

        [Display(Name = "PointArrive", ResourceType = typeof(Resources.Models.Trajet))]
        public string PointArrive { get; set; }

        [Display(Name = "Prix", ResourceType = typeof(Resources.Models.Trajet))]
        public int Prix { get; set; }

        [Display(Name = "VilleDestination", ResourceType = typeof(Resources.Models.Trajet))]
        public string VilleDestination { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "HeurDepart", ResourceType = typeof(Resources.Models.Trajet))]

        public DateTime HeureDepart { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "HeurArrive", ResourceType = typeof(Resources.Models.Trajet))]

        public DateTime HeureArrivee { get; set; }

        [Display(Name = "NbPassagers", ResourceType = typeof(Resources.Models.Trajet))]
        public int NbPassagers { get; set; }

        [Display(Name = "Kilometrage", ResourceType = typeof(Resources.Models.Trajet))]
        public int Kilometrage { get; set; }
    }
}