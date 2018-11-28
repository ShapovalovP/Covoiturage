using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetCovoiturage.DAL;
using ProjetCovoiturage.Models;

namespace ProjetCovoiturage.Services
{
    public class ServiceTrajet : IServiceTrajet
    {
        private UnitOfWork uw;

        public ServiceTrajet(UnitOfWork _uw)
        {
            uw = _uw;
        }

        public void AjouterTrajet(Trajet unTrajet)
        {
            uw.TrajetRepository.Insert(unTrajet);
            uw.Save();
        }

        public List<Trajet> ListeTrajets()
        {
            return uw.TrajetRepository.Get().ToList();
        }

        public void ModifierTrajet(Trajet unTrajet)
        {
            uw.TrajetRepository.Update(unTrajet);
            uw.Save();
        }

        public void SupprimerTrajet(Trajet unTrajet)
        {
            uw.TrajetRepository.Delete(unTrajet);
            uw.Save();
        }

        public Trajet TrouverTrajet(int? id)
        {
            return uw.TrajetRepository.GetByID(id);
        }
    }
}