using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class NotesClient
    {
        [Key]
        public int noteID { get; set; }

        public int clientID { get; set; }

        public int trajetID { get; set; }

        [Range(0, 5)]
        public int note { get; set; }
    }
}