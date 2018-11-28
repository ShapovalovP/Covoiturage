using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetCovoiturage.DAL;
using ProjetCovoiturage.Models;

namespace ProjetCovoiturage.Services
{
    public class ServiceClient : IServiceClient
    {
        private UnitOfWork uw;

        public ServiceClient(UnitOfWork _uw)
        {
            uw = _uw;
        }

        public void AjouterClient(Client unClient)
        {
            uw.ClientRepository.Insert(unClient);
            uw.Save();
        }

        public List<Client> ListeClients()
        {
            return uw.ClientRepository.Get().ToList();
        }

        public void ModifierClient(Client unClient)
        {
            uw.ClientRepository.Update(unClient);
            uw.Save();
        }

        public void SupprimerClient(Client unClient)
        {
            uw.ClientRepository.Delete(unClient);
            uw.Save();
        }

        public Client TrouverClient(int? id)
        {
            return uw.ClientRepository.GetByID(id);
        }
    }
}