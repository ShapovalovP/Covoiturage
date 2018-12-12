using ProjetCovoiturage.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    [Ajout24hValidation]

    public class TrajetHeureDate
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "DepartureCity", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Required(ErrorMessageResourceName = "DepartureCityRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public string VilleDepart { get; set; }

        [Display(Name = "StartingPoint", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Required(ErrorMessageResourceName = "StartingPointRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public string PointDepart { get; set; }

        [Display(Name = "ArrivalPoint", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Required(ErrorMessageResourceName = "ArrivalPointRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public string PointArrivee { get; set; }

        [Display(Name = "Price", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Required(ErrorMessageResourceName = "PriceRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public int Prix { get; set; }

        [Display(Name = "ArrivalCity", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Required(ErrorMessageResourceName = "ArrivalCityRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public string VilleDestination { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessageResourceName = "DepartureDateRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Display(Name = "DepartureDate", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public DateTime DateDepart { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "DepartureHour", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Required(ErrorMessageResourceName = "DepartureHourRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public DateTime HeureDepart { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessageResourceName = "ArrivalDateRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Display(Name = "ArrivalDate", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public DateTime DateArrivee { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "ArrivalHour", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Required(ErrorMessageResourceName = "ArrivalHourRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public DateTime HeureArrivee { get; set; }

        [Required(ErrorMessageResourceName = "NumberSeatsLeftRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Display(Name = "NumberSeatsLeft", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public int PlaceRestante { get; set; }
        
        [Required(ErrorMessageResourceName = "MileageRequiredError", ErrorMessageResourceType = typeof(Resources.Models.TrajetHeureDate))]
        [Display(Name = "Mileage", ResourceType = typeof(Resources.Models.TrajetHeureDate))]
        public int Kilometrage { get; set; }
    }
}