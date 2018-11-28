using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Services
{
    public interface IServiceTrajet
    {
        void AjouterTrajet(Trajet unTrajet);

        void ModifierTrajet(Trajet unTrajet);

        Trajet TrouverTrajet(int? id);

        List<Trajet> ListeTrajets();

        void SupprimerTrajet(Trajet unTrajet);
    }
}