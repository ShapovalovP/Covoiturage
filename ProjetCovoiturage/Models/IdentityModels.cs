using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace ProjetCovoiturage.Models
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant d'autres propriétés à votre classe ApplicationUser. Pour en savoir plus, consultez https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {

        [Required(ErrorMessageResourceName = "FirstNameRequiredError", ErrorMessageResourceType = typeof(Resources.Models.IdentityModel))]
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Models.IdentityModel))]
        public string Firstname { get; set; }

        [Required(ErrorMessageResourceName = "LastNameRequiredError", ErrorMessageResourceType = typeof(Resources.Models.IdentityModel))]
        [Display(Name = "LastName", ResourceType = typeof(Resources.Models.IdentityModel))]
        public string Lastname { get; set; }

        [Required(ErrorMessageResourceName = "CityRequiredError", ErrorMessageResourceType = typeof(Resources.Models.IdentityModel))]
        [Display(Name = "City", ResourceType = typeof(Resources.Models.IdentityModel))]
        public string Ville { get; set; }

        [Required(ErrorMessageResourceName = "AgeRequiredError", ErrorMessageResourceType = typeof(Resources.Models.IdentityModel))]
        [Display(Name = "Age", ResourceType = typeof(Resources.Models.IdentityModel))]
        public string Age { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Notez qu'authenticationType doit correspondre à l'élément défini dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Ajouter les revendications personnalisées de l’utilisateur ici
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Chauffeur> Chauffeur { get; set; }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Trajet> Trajets { get; set; }

        public virtual DbSet<Voiture> Voitures { get; set; }

        public virtual DbSet<NotesChauffeurs> NotesChauffeurs { get; set; }
    }
}