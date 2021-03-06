﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class NotesClient
    {
        [Key]
        [Display(Name = "RateID", ResourceType = typeof(Resources.Views.Stats))]
        public int noteID { get; set; }

        [Display(Name = "customerID", ResourceType = typeof(Resources.Views.Stats))]
        public int clientID { get; set; }

        [Display(Name = "RideID", ResourceType = typeof(Resources.Views.Stats))]
        public int trajetID { get; set; }

        [Range(0, 5)]
        [Display(Name = "rate", ResourceType = typeof(Resources.Views.Stats))]
        public int note { get; set; }
    }
}