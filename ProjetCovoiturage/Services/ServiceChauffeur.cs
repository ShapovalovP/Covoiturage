using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetCovoiturage.DAL;
using ProjetCovoiturage.Models;

namespace ProjetCovoiturage.Services
{
    public class ServiceChauffeur : IServiceChauffeur
    {
        private UnitOfWork uw;

        public ServiceChauffeur(UnitOfWork _uw)
        {
            uw = _uw;
        }

        public void AjouterChauffeur(Chauffeur unChauffeur)
        {
            uw.ChauffeurRepository.Insert(unChauffeur);
            uw.Save();
        }

        public List<Chauffeur> ListeChauffeurs()
        {
            return uw.ChauffeurRepository.Get().ToList();
        }

        public void ModifierChauffeur(Chauffeur unChauffeur)
        {
            uw.ChauffeurRepository.Update(unChauffeur);
            uw.Save();
        }

        public void SupprimerChauffeur(Chauffeur unChauffeur)
        {
            uw.ChauffeurRepository.Delete(unChauffeur);
            uw.Save();
        }

        public Chauffeur TrouverChauffeur(int? id)
        {
            return uw.ChauffeurRepository.GetByID(id);
        }
    }
}