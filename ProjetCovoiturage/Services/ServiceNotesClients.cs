using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetCovoiturage.DAL;
using ProjetCovoiturage.Models;

namespace ProjetCovoiturage.Services
{
    public class ServiceNotesClients : IServiceNotesClients
    {
        private UnitOfWork uw;

        public ServiceNotesClients(UnitOfWork _uw)
        {
            uw = _uw;
        }

        public void AjouterNotesClients(NotesClient unNotesClients)
        {
            uw.NotesClientsRepository.Insert(unNotesClients);
            uw.Save();
        }

        public List<NotesClient> ListeNotesClient()
        {
            return uw.NotesClientsRepository.Get().ToList();
        }

        public void ModifierNotesClient(NotesClient unNotesClient)
        {
            uw.NotesClientsRepository.Update(unNotesClient);
            uw.Save();
        }

        public void SupprimerNotesClient(NotesClient unNotesClient)
        {
            uw.NotesClientsRepository.Delete(unNotesClient);
            uw.Save();
        }

        public NotesClient TrouverNotesClient(int? id)
        {
            return uw.NotesClientsRepository.GetByID(id);
        }
    }
}