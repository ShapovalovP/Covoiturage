using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Services
{
    public interface IServiceClient
    {
        void AjouterClient(Client unClient);

        void ModifierClient(Client unClient);

        Client TrouverClient(int? id);

        List<Client> ListeClients();

        void SupprimerClient(Client unClient);
    }
}