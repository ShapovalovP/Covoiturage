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
        public int chauffeurId { get; set; }

        [Required]
        [Range(0, 5)]
        public int notePonctualite { get; set; }

        [Range(0, 5)]
        public int noteSecurite { get; set; }

        [Range(0, 5)]
        public int noteConfort { get; set; }

        [Range(0, 5)]
        public int noteCourtoisie { get; set; }

        [Range(0, 5)]
        public int noteFiabilite { get; set; }

        public virtual Chauffeur chaufeurs { get; set; }
    }
}