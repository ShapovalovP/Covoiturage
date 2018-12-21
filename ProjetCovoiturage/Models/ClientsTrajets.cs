using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class ClientsTrajets
    {

        public int Client_ClientID { get; set; }

        public Boolean IsPayed { get; set; }

        public int Trajet_Id { get; set; }

        public virtual Client client { get; set; }
        public virtual Trajet trajet { get; set; }
    }
}