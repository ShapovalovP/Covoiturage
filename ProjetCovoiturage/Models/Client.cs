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

        [Required]
        [DisplayName("Prénom")]
        public string ClientPrenom { get; set; }

        [Required]
        [DisplayName("Nom")]
        public string ClientNom { get; set; }

        [Required]
        [DisplayName("Téléphone")]
        public string TelephoneClient { get; set; }

        [Required]
        [DisplayName("Âge")]
        [Range(21, 70)]
        public int AgeClient { get; set; }

        [Required]
        [DisplayName("Ville")]
        public string VilleClient { get; set; }

        public virtual Trajet Trajet { get; set; }
    }
}