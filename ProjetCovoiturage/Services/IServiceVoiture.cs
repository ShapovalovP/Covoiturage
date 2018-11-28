using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Services
{
    public interface IServiceVoiture
    {
        void AjouterVoiture(Voiture uneVoiture);

        void ModifierVoiture(Voiture uneVoiture);

        Voiture TrouverVoiture(int? id);

        List<Voiture> ListeVoitures();

        void SupprimerVoiture(Voiture uneVoiture);
    }
}