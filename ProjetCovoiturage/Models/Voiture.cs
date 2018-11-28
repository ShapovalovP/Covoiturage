using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class Voiture
    {
        public int VoitureID { get; set; }

        public string ModeleVoiture { get; set; }

        public DateTime dateMiseRoute { get; set; }

        public int nbPlace { get; set; }


        public virtual ICollection<Chauffeur> Chauffeurs { get; set; }
    }
}