using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Services
{
    public interface IServiceChauffeur
    {
        void AjouterChauffeur(Chauffeur unChauffeur);

        void ModifierChauffeur(Chauffeur unChauffeur);

        Chauffeur TrouverChauffeur(int? id);

        List<Chauffeur> ListeChauffeurs();

        void SupprimerChauffeur(Chauffeur unChauffeur);
    }
}