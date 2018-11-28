﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ProjetCovoiturage.Models;
using ProjetCovoiturage.Services;
using ProjetCovoiturage.ViewModels;

namespace ProjetCovoiturage.Controllers
{
    public class TrajetsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private IServiceTrajet _st;

        public TrajetsController(IServiceTrajet pst)
        {
            _st = pst;
        }

        // GET: Trajets
        public ActionResult Index()
        {
            return View(db.Trajets.ToList());
        }
        public ActionResult FiltreTrajets(DateTime? datD, DateTime? datA, string villDepar, string villeArive)
        {
            // string tous = Session["Culture"].ToString() == "en" ? "ALL" : "Tout";

            ViewBag.listVilleDep = new SelectList(_st.listVilleDep());
            ViewBag.listVilleAriv = new SelectList(_st.listVilleArriv());
            DateTime dD = new DateTime();
            DateTime dF = new DateTime();
            if (datD == null || datA == null)
            {
                dD = DateTime.Today;
                dF = DateTime.Today;
            }
            else
            {
                dD = (DateTime)datD;
                dF = (DateTime)datA;
            }


            List<Trajet> list = _st.ListeTrajets(); // _st.GetListeTrajetsBy(dD, dF, villDepar, villeArive);
            VMFiltreTrajets v = new VMFiltreTrajets { calendarD = dD, calendarF = dF, villeDepart = "villeDep", villeDestination = "villearive", listTraj = list };

            return View(v);
        }
        // GET: Trajets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trajet trajet = db.Trajets.Find(id);
            if (trajet == null)
            {
                return HttpNotFound();
            }
            return View(trajet);
        }

        // GET: Trajets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trajets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Chauffeur")]
        public ActionResult Create([Bind(Include = "Id,VilleDepart,PointDepart,PointArrive,Prix,VilleDestination,DateDepart,HeureDepart,DateArrivee,HeureArrivee")] TrajetHeureDate trajet)
        {
            if (ModelState.IsValid)
            {
               Chauffeur chauffeur= db.Chauffeur.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
                DateTime heurearrive = new DateTime(trajet.DateArrivee.Year, trajet.DateArrivee.Month, trajet.DateArrivee.Day, trajet.HeureArrivee.Hour, trajet.HeureArrivee.Minute, trajet.HeureArrivee.Second);
                DateTime heuredepart = new DateTime(trajet.DateDepart.Year, trajet.DateDepart.Month, trajet.DateDepart.Day, trajet.HeureDepart.Hour, trajet.HeureDepart.Minute, trajet.HeureDepart.Second);
                Trajet newtrajet = new Trajet { Chauffeur=chauffeur,HeureArrivee = heurearrive, HeureDepart = heuredepart, PointDepart = trajet.PointDepart, PointArrive = trajet.PointArrive, Id = trajet.Id, Prix = trajet.Prix, VilleDepart = trajet.VilleDepart, VilleDestination = trajet.VilleDestination };
                db.Trajets.Add(newtrajet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trajet);
        }

        // GET: Trajets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trajet trajet = db.Trajets.Find(id);
            if (trajet == null)
            {
                return HttpNotFound();
            }
            return View(trajet);
        }

        // POST: Trajets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VilleDepart,PointDepart,PointArrive,Prix,VilleDestination,HeureDepart,HeureArrivee")] Trajet trajet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trajet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trajet);
        }

        // GET: Trajets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trajet trajet = db.Trajets.Find(id);
            if (trajet == null)
            {
                return HttpNotFound();
            }
            return View(trajet);
        }

        // POST: Trajets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trajet trajet = db.Trajets.Find(id);
            db.Trajets.Remove(trajet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
