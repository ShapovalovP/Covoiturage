using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class NotesChauffeurs
    {
        [Key]
        [Required]
        public int noteId { get; set; }

        [Required]

        [Range(0,5)]
        public int notePonctualitée { get; set; }

        [Range(0, 5)]
        public  int noteSecuritée { get; set; }

        [Range(0, 5)]
        public int noteConfort { get; set; }

        [Range(0, 5)]
        public int noteCourtoisie { get; set; }

        [Range(0, 5)]
        public int noteFiabilitée { get; set; }

        public virtual Chauffeur chaufeurs { get;set; }
    }
}