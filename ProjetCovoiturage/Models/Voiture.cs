using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class Voiture
    {
        public int VoitureID { get; set; }

        [Required(ErrorMessageResourceName = "CarModelRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Voiture))]
        [Display(Name = "CarModel", ResourceType = typeof(Resources.Models.Voiture))]
        public string ModeleVoiture { get; set; }

        [Required(ErrorMessageResourceName = "DateRoadRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Voiture))]
        [Display(Name = "DateRoad", ResourceType = typeof(Resources.Models.Voiture))]
        public DateTime dateMiseRoute { get; set; }

        [Required(ErrorMessageResourceName = "SeatsNumberRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Voiture))]
        [Display(Name = "SeatsNumber", ResourceType = typeof(Resources.Models.Voiture))]
        public int nbPlace { get; set; }


        public virtual ICollection<Chauffeur> Chauffeurs { get; set; }
    }
}