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
        public int noteId { get; set; }

        [Required(ErrorMessageResourceName = "PunctualityRatingRequiredError", ErrorMessageResourceType = typeof(Resources.Models.NotesChauffeur))]
        [Display(Name = "PunctualityRating", ResourceType = typeof(Resources.Models.NotesChauffeur))]
        [Range(0,5)]
        public int notePonctualite { get; set; }

        [Required(ErrorMessageResourceName = "SecurityRatingRequiredError", ErrorMessageResourceType = typeof(Resources.Models.NotesChauffeur))]
        [Display(Name = "SecurityRating", ResourceType = typeof(Resources.Models.NotesChauffeur))]
        [Range(0, 5)]
        public  int noteSecurite { get; set; }

        [Required(ErrorMessageResourceName = "ComfortRatingRequiredError", ErrorMessageResourceType = typeof(Resources.Models.NotesChauffeur))]
        [Display(Name = "ComfortRating", ResourceType = typeof(Resources.Models.NotesChauffeur))]
        [Range(0, 5)]
        public int noteConfort { get; set; }

        [Required(ErrorMessageResourceName = "CourtesyRatingRequiredError", ErrorMessageResourceType = typeof(Resources.Models.NotesChauffeur))]
        [Display(Name = "CourtesyRating", ResourceType = typeof(Resources.Models.NotesChauffeur))]
        [Range(0, 5)]
        public int noteCourtoisie { get; set; }

        [Required(ErrorMessageResourceName = "ReliabilityRatingRequiredError", ErrorMessageResourceType = typeof(Resources.Models.NotesChauffeur))]
        [Display(Name = "ReliabilityRating", ResourceType = typeof(Resources.Models.NotesChauffeur))]
        [Range(0, 5)]
        public int noteFiabilite { get; set; }

        public virtual Chauffeur chaufeurs { get;set; }
    }
}