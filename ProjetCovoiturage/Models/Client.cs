using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required(ErrorMessageResourceName = "FirstNameRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Client))]
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Models.Client))]
        public string ClientPrenom { get; set; }

        [Required(ErrorMessageResourceName = "LastNameRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Client))]
        [Display(Name = "LastName", ResourceType = typeof(Resources.Models.Client))]
        public string ClientNom { get; set; }

        [Required(ErrorMessageResourceName = "PhoneNumberRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Client))]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources.Models.Client))]
        public string TelephoneClient { get; set; }

        [Required(ErrorMessageResourceName = "AgeRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Client))]
        [Display(Name = "Age", ResourceType = typeof(Resources.Models.Client))]
        [Range(21, 70)]
        public int AgeClient { get; set; }

        [Required(ErrorMessageResourceName = "CityRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Client))]
        [Display(Name = "Ville", ResourceType = typeof(Resources.Models.Client))]
        public string VilleClient { get; set; }

        public virtual ICollection<Trajet> Trajets { get; set; }

    }
}