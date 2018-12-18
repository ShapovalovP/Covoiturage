using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Services
{
    public interface IServiceNotesClients
    {
        void AjouterNotesClients(NotesClient unNotesClients);

        void ModifierNotesClient(NotesClient unNotesClient);

        NotesClient TrouverNotesClient(int? id);

        List<NotesClient> ListeNotesClient();

        void SupprimerNotesClient(NotesClient unNotesClient);
    }
}