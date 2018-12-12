using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace ProjetCovoiturage.Models
{
    public class IndexViewModel
    {
        [Required(ErrorMessageResourceName = "HasPasswordRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [Display(Name = "HasPassword", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public bool HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }

        [Required(ErrorMessageResourceName = "PhoneNumberRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public string PhoneNumber { get; set; }
   
        [Required(ErrorMessageResourceName = "TwoFactorRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [Display(Name = "TwoFactor", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public bool TwoFactor { get; set; }

        [Required(ErrorMessageResourceName = "BrowserRememberedRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [Display(Name = "BrowserRemembered", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public bool BrowserRemembered { get; set; }

    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        [Required(ErrorMessageResourceName = "PurposeRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [Display(Name = "Purpose", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required(ErrorMessageResourceName = "NewPasswordRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [StringLength(100, ErrorMessage = "Le {0} doit compter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassword", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public string NewPassword { get; set; }

        [Required(ErrorMessageResourceName = "ConfirmPasswordRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Models.ManageViewModels))]
        [Compare("NewPassword", ErrorMessage = "Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required(ErrorMessageResourceName = "OldPasswordRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [DataType(DataType.Password)]
        [Display(Name = "OldPassword", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public string OldPassword { get; set; }

        [Required(ErrorMessageResourceName = "NewPasswordRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [StringLength(100, ErrorMessage = "Le {0} doit compter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassword", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public string NewPassword { get; set; }

        [Required(ErrorMessageResourceName = "ConfirmPasswordRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Models.ManageViewModels))]
        [Compare("NewPassword", ErrorMessage = "Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required(ErrorMessageResourceName = "PhoneNumberRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [Phone]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required(ErrorMessageResourceName = "CodeRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [Display(Name = "Code", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public string Code { get; set; }

        [Required(ErrorMessageResourceName = "PhoneNumberRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [Phone]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        [Required(ErrorMessageResourceName = "SelectedProvidersRequiredError", ErrorMessageResourceType = typeof(Resources.Models.ManageViewModels))]
        [Display(Name = "SelectedProviders", ResourceType = typeof(Resources.Models.ManageViewModels))]
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}