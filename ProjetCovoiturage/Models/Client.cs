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

        public string UserId { get; set; }

        public virtual ICollection<ClientsTrajets> ClientTrajet { get; set; }

    }
}