using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetCovoiturage.DAL;
using ProjetCovoiturage.Models;
using ProjetCovoiturage.ViewModels;

namespace ProjetCovoiturage.Services
{
    public class ServiceTrajet : IServiceTrajet
    {
        private UnitOfWork uw = new UnitOfWork(new ApplicationDbContext());;

        public ServiceTrajet(UnitOfWork _uw)
        {
            uw = _uw;
        }

        public void AjouterTrajet(Trajet unTrajet)
        {
            uw.TrajetRepository.Insert(unTrajet);
            uw.Save();
        }

        public Trajet DetailTraget(int? id)
        {
            return uw.TrajetRepository.GetByID(id);
        }

        public VMChauffeurDeTrajet DetailTragetChauffeur(int? id)
        {
            Trajet trajCourant = uw.TrajetRepository.GetByID(id);

            Chauffeur ch = uw.ChauffeurRepository.GetByID(trajCourant.IdChauffeur);
            DateTime dToday = DateTime.Today;
            var rezz = this.ListeTrajets().ToList();
            rezz = rezz.Where(x => x.IdChauffeur == trajCourant.IdChauffeur && x.HeureArrivee < dToday).ToList();
            //  rezz = rezz.Where(x => x.HeureArrivee < dToday).ToList();
            int qtyTraj = rezz.Count;
            int kilometreTotal = 0;

            foreach (Trajet t in rezz)
            {
                kilometreTotal += t.Kilometrage;
            }
            /* var  rez = (from repons in ListeTrajets()//GetReponsesByTous(datD, datF, a, n, progr, m, session)
                      // join emo in listE on repons.idEmotion equals emo.idEmotion
                    group repons by new
                    {
                        n = lang.ToString() == "fr" || lang == null ? emo.nom : emo.nomE
                    } into gr
                    select new ChartDay
                    {
                        nom = gr.Key.n,
                        qty = gr.Count()
                    }).ToList();*/


            VMChauffeurDeTrajet v = new VMChauffeurDeTrajet()
            {
                nbTrajets = qtyTraj.ToString(),
                nbKilometres = kilometreTotal.ToString(),
                moyenneApreci = "4.5",///Pomeniat!!! moyennes des appréciations de ses clients 1 ) sozdat tablicy Apreciation c itTarjet 
                HeureDepart = trajCourant.HeureDepart,
                HeureArrivee = trajCourant.HeureArrivee,
                NbPassagers = trajCourant.NbPassagers,
                Prix = trajCourant.Prix,
                Kilometrage = trajCourant.Kilometrage,
                VilleDepart = trajCourant.VilleDepart,
                PointDepart = trajCourant.PointArrive,
                VilleDestination = trajCourant.VilleDestination,
                PointArrive = trajCourant.PointArrive,
            };

            return v;
        }

        public List<Trajet> GetListeTrajetsBy(DateTime? datDepart, DateTime? datArive, string villeDepart, string villeArive)
        {
            var rez = this.ListeTrajets().ToList();
            if (villeDepart != null && villeDepart != "select")
            {
                rez = rez.Where(x => x.VilleDepart == villeDepart).ToList();

            }

            if (villeArive != null && villeArive != "select")
            {
                rez = rez.Where(x => x.VilleDestination == villeArive).ToList();

            }


            if (datDepart != null)
            {
                rez = rez.Where(x => x.HeureDepart == datDepart).ToList();

            }
            if (datArive != null)
            {
                rez = rez.Where(x => x.HeureDepart == datDepart).ToList();

            }


            return rez;
        }

        public List<Trajet> ListeTrajets()
        {
            return uw.TrajetRepository.Get().ToList();
        }

        public List<string> listVilleArriv()
        {
            List<String> lis = new List<string>();
            lis.Add("select");

            foreach (Trajet r in ListeTrajets())
            {
                if (!lis.Contains(r.VilleDestination.ToString()))
                {
                    lis.Add(r.VilleDestination.ToString());
                }
            }
            return lis;
        }

        public List<string> listVilleDep()
        {
            List<String> lis = new List<string>();
            lis.Add("select");
            foreach (Trajet r in ListeTrajets())
            {
                if (!lis.Contains(r.VilleDepart.ToString()))
                {
                    lis.Add(r.VilleDepart.ToString());
                }
            }
            return lis;
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