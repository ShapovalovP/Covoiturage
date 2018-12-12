using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class Chauffeur
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessageResourceName = "FirstNameRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Chauffeur))]
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Models.Chauffeur))]
        public string Prenom { get; set; }

        [Required(ErrorMessageResourceName = "LastNameRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Chauffeur))]
        [Display(Name = "LastName", ResourceType = typeof(Resources.Models.Chauffeur))]
        public string Nom { get; set; }

        [Required(ErrorMessageResourceName = "LicenseNumberRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Chauffeur))]
        [Display(Name = "LicenseNumber", ResourceType = typeof(Resources.Models.Chauffeur))]
        public string NumeroPermis { get; set; }

        [Required(ErrorMessageResourceName = "EmailRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Chauffeur))]
        [Display(Name = "Email", ResourceType = typeof(Resources.Models.Chauffeur))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "PhoneNumberRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Chauffeur))]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources.Models.Chauffeur))]
        public int NumeroTelephone { get; set; }

        [Required(ErrorMessageResourceName = "CityRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Chauffeur))]
        [Display(Name = "City", ResourceType = typeof(Resources.Models.Chauffeur))]
        public string Ville { get; set; }

        [Required(ErrorMessageResourceName = "LicenseDateRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Chauffeur))]
        [Display(Name = "LicenseDate", ResourceType = typeof(Resources.Models.Chauffeur))]
        public DateTime DatePermis { get; set; }

        [Required(ErrorMessageResourceName = "HiringDateRequiredError", ErrorMessageResourceType = typeof(Resources.Models.Chauffeur))]
        [Display(Name = "HiringDate", ResourceType = typeof(Resources.Models.Chauffeur))]
        public DateTime DateEmbauche { get; set; }

        public virtual ICollection<Voiture> Voiture { get; set; }

        public virtual ICollection<NotesChauffeurs> NotesChauffeurs { get; set; }

        public virtual ICollection<Trajet> Trajets { get; set; }

        public bool Public { get; set; }
    }
}