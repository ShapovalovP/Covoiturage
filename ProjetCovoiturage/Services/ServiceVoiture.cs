using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetCovoiturage.DAL;
using ProjetCovoiturage.Models;

namespace ProjetCovoiturage.Services
{
    public class ServiceVoiture : IServiceVoiture
    {
        private UnitOfWork uw;

        public ServiceVoiture(UnitOfWork _uw)
        {
            uw = _uw;
        }

        public void AjouterVoiture(Voiture uneVoiture)
        {
            uw.VoitureRepository.Insert(uneVoiture);
            uw.Save();
        }

        public List<Voiture> ListeVoitures()
        {
            return uw.VoitureRepository.Get().ToList();
        }

        public void ModifierVoiture(Voiture uneVoiture)
        {
            uw.VoitureRepository.Update(uneVoiture);
            uw.Save();
        }

        public void SupprimerVoiture(Voiture uneVoiture)
        {
            uw.VoitureRepository.Delete(uneVoiture);
            uw.Save();
        }

        public Voiture TrouverVoiture(int? id)
        {
            return uw.VoitureRepository.GetByID(id);
        }
    }
}