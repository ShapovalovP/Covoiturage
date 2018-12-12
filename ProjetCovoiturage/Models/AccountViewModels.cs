using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetCovoiturage.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessageResourceName = "EmailRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "Email", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        [Display(Name = "ReturnUrl", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        [Display(Name = "SelectedProvider", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string SelectedProvider { get; set; }

        [Display(Name = "Provider", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public ICollection<SelectListItem> Providers { get; set; }

        [Display(Name = "ReturnUrl", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string ReturnUrl { get; set; }

        [Display(Name = "RememberMe", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required(ErrorMessageResourceName = "ProviderRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "Provider", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Provider { get; set; }

        [Required(ErrorMessageResourceName = "CodeRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "Code", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Code { get; set; }

        [Display(Name = "ReturnUrl", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string ReturnUrl { get; set; }

        [Display(Name = "RememberBrowser", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public bool RememberBrowser { get; set; }

        [Display(Name = "RememberMe", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required(ErrorMessageResourceName = "EmailRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "Email", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessageResourceName = "EmailRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "Email", ResourceType = typeof(Resources.Models.AccountViewModel))]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "PasswordRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Password { get; set; }

        [Display(Name = "RememberPassword", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public bool RememberMe { get; set; }
    }
    public class RegisterViewModelClient
    {
        [Required(ErrorMessageResourceName = "EmailRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "FirstNameRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Firstname { get; set; }

        [Required(ErrorMessageResourceName = "LastNameRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "LastName", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Lastname { get; set; }

        [Required(ErrorMessageResourceName = "CityRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "City", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Ville { get; set; }

        [Required(ErrorMessageResourceName = "AgeRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "Age", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Age { get; set; }

        [Required(ErrorMessageResourceName = "PhoneNumerRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessageResourceName = "PasswordRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [StringLength(100, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Models.AccountViewModel))]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Le mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }
    public class RegisterViewModelChauffeur
    {
        [Required(ErrorMessageResourceName = "EmailRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "FirstNameRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Prenom { get; set; }

        [Required(ErrorMessageResourceName = "LastNameRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "LastName", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Nom { get; set; }

        [Required(ErrorMessageResourceName = "LicenseNumberRequiredError", ErrorMessageResourceType =typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "LicenseNumber", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string NumeroPermis { get; set; }

        [Required(ErrorMessageResourceName = "PhoneNumerRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public int NumeroTelephone { get; set; }

        [Required(ErrorMessageResourceName = "CityRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "City", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Ville { get; set; }

        [Required(ErrorMessageResourceName = "LicenseDateRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "LicenseDate", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public DateTime DatePermis { get; set; }

        [Required(ErrorMessageResourceName = "HiringDateRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "HiringDate", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public DateTime DateEmbauche { get; set; }

        [Required(ErrorMessageResourceName = "CarModelRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "CarModel", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string VehiculeModel { get; set; }

        [Required(ErrorMessageResourceName = "DateRoadRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DateRoad", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public DateTime DateEnRoute { get; set; }

        [Required(ErrorMessageResourceName = "SeatsNumberRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [Display(Name = "SeatsNumber", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public int NbPlace { get; set; }

        [Required(ErrorMessageResourceName = "PasswordRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [StringLength(100, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Models.AccountViewModel))]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Le mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
        public bool Public { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessageResourceName = "EmailRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "PasswordRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [StringLength(100, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Models.AccountViewModel))]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessageResourceName = "EmailRequiredError", ErrorMessageResourceType = typeof(Resources.Models.AccountViewModel))]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Resources.Models.AccountViewModel))]
        public string Email { get; set; }
    }
}
