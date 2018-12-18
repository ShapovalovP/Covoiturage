using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.ViewModels
{
    public class VMStatsClients
    {
        [Display(Name = "customerID", ResourceType = typeof(Resources.Views.Stats))]
        public int clientID { get; set; }

        [Display(Name = "rate", ResourceType = typeof(Resources.Views.Stats))]
        public int note { get; set; }
    }
}