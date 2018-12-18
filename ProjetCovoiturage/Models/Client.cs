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
        [Display(Name = "customerID", ResourceType = typeof(Resources.Views.Stats))]
        public int ClientID { get; set; }

        [Display(Name = "UserID", ResourceType = typeof(Resources.Views.Stats))]
        public string UserId { get; set; }

        public virtual ICollection<ClientsTrajets> ClientTrajet { get; set; }

    }
}