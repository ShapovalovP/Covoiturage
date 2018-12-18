using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.ViewModels
{
    public class VMStatsVille
    {
        [Display(Name = "ArrivalCity", ResourceType = typeof(Resources.Views.Stats))]
        public string nomVilleArrivee { get; set; }

        [Display(Name = "Mph", ResourceType = typeof(Resources.Views.Stats))]
        public int km { get; set; }
    }
}