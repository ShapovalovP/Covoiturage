using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class Trajet
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "DepartureCity", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "DepartureCityRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public string VilleDepart { get; set; }

        [Display(Name = "StartingPoint", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "StartingPointRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public string PointDepart { get; set; }

        [Display(Name = "ArrivalPoint", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "ArrivalPointRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public string PointArrivee { get; set; }

        [Display(Name = "Price", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "PriceRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public int Prix { get; set; }

        [Display(Name = "ArrivalCity", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "ArrivalCityRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public string VilleDestination { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "DepartureHour", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "DepartureHourRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public DateTime HeureDepart { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "ArrivalHour", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "ArrivalHourRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public DateTime HeureArrivee { get; set; }

        [Display(Name = "Mileage", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "MileageRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public int Kilometrage { get; set; }

        public virtual ICollection<ClientsTrajets> ClientTrajet { get; set; }
        public virtual Chauffeur Chauffeur { get; set; }

        [Display(Name = "NumberSeatsLeft", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "NumberSeatsLeftRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public int PlaceRestante { get; set; }
    }
}