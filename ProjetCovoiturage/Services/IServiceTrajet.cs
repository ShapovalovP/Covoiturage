using ProjetCovoiturage.Models;
using ProjetCovoiturage.ViewModels;
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
        List<String> listVilleDep();
        List<String> listVilleArriv();
        Trajet DetailTraget(int? id);
        VMChauffeurDeTrajet DetailTragetChauffeur(int? id);
        List<Trajet> GetListeTrajetsBy(DateTime? datDepart, DateTime? datArive, string villeDepart, string villeArive);
    }
}