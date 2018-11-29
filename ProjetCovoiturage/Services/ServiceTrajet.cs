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
        private UnitOfWork uw = new UnitOfWork(new ApplicationDbContext());

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

           // Chauffeur ch = uw.ChauffeurRepository.GetByID(trajCourant.Chauffeur);
            DateTime dToday = DateTime.Today;
            var rezz = this.ListeTrajets().ToList();
            rezz = rezz.Where(x => x.Chauffeur == trajCourant.Chauffeur && x.HeureArrivee < dToday).ToList();
            
            int qtyTraj = rezz.Count;
            int kilometreTotal = 0;
            decimal ponctual= 0;
            decimal securite = 0;
            decimal comfort = 0;
            decimal courtoisie = 0;
            decimal fiabilite = 0;

            int p = 0;
            int s = 0;
            int comf = 0;
            int cour = 0;
            int fiab = 0;

            var notss = ListeNotes();
            List<NotesChauffeurs> nots = new List<NotesChauffeurs>();
            foreach (NotesChauffeurs n in notss)
            {
                if( n.chaufeurs == trajCourant.Chauffeur)
                {
                    nots.Add(n);
                }
            }

           // nots = nots.Where(x => x.chaufeurs == trajCourant.Chauffeur);

            if (nots.Count() > 0)
            {

                foreach (NotesChauffeurs n in nots)
                {
                    p = p + n.notePonctualite;
                    s = s + n.noteSecurite;
                    comf = comf + n.noteConfort;
                    cour = cour + n.noteCourtoisie;
                    fiab = fiab + n.noteFiabilite;
                }

                ponctual = (decimal)p / (decimal)nots.Count();
                securite = (decimal)s / (decimal)nots.Count();
                comfort = (decimal)comf / (decimal)nots.Count();
                courtoisie = (decimal)cour / (decimal)nots.Count();
                fiabilite = (decimal)fiab / (decimal)nots.Count();
            }
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

                moyennePonctualite = ponctual.ToString(),///Pomeniat!!! moyennes des appréciations de ses clients 1 ) sozdat tablicy Apreciation c itTarjet 
                moyenneSecurite = securite.ToString(),
                moyenneConfort = comfort.ToString(),
                moyenneCourtoisie = courtoisie.ToString(),
                moyenneFiabilite = fiabilite.ToString(),

                HeureDepart = trajCourant.HeureDepart,
                HeureArrivee = trajCourant.HeureArrivee,
                NbPassagers = trajCourant.PlaceRestante,
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

        public List<NotesChauffeurs> ListeNotes()
        {
            return uw.NotesChauffeursRepository.Get().ToList();
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