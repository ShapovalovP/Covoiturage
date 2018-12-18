using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetCovoiturage.Models;
using ProjetCovoiturage.Services;

namespace ProjetCovoiturage.Controllers
{
    public class NotesClientsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        readonly IServiceNotesClients _serviceNotesClients;

        public NotesClientsController(IServiceNotesClients sp)
        {
            this._serviceNotesClients = sp;
        }

        // GET: NotesClients
        public ActionResult Index()
        {
            var data = _serviceNotesClients.ListeNotesClient();
            return View(data);
        }

        // GET: NotesClients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var data = _serviceNotesClients.TrouverNotesClient(id);

            if (data == null)
            {
                return HttpNotFound();
            }

            return View(data);
        }

        // GET: NotesClients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotesClients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noteID,clientID,trajetID,note")] NotesClient notesClient)
        {
            if (ModelState.IsValid)
            {
                _serviceNotesClients.AjouterNotesClients(notesClient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notesClient);
        }

        // GET: NotesClients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var data = _serviceNotesClients.TrouverNotesClient(id);

            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }

        // POST: NotesClients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noteID,clientID,trajetID,note")] NotesClient notesClient)
        {
            if (ModelState.IsValid)
            {
                _serviceNotesClients.ModifierNotesClient(notesClient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notesClient);
        }

        // GET: NotesClients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var data = _serviceNotesClients.TrouverNotesClient(id);
            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }

        // POST: NotesClients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var data = _serviceNotesClients.TrouverNotesClient(id);
            _serviceNotesClients.SupprimerNotesClient(data);
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

        public ActionResult StatsClients()
        {
            var query = from notes in db.NotesClients
                        group notes by notes.clientID into groupe
                        select new ViewModels.VMStatsClients
                        {
                            clientID = groupe.Key,
                            note = (int)(groupe.Select(x => x.note).Average())
                        };

            return View("StatsClients", query);
        }

        public ActionResult StatsVille()
        {
            var query = from trajet in db.Trajets
                        group trajet by trajet.VilleDestination into groupe
                        select new ViewModels.VMStatsVille
                        {
                            nomVilleArrivee = groupe.Key,
                            km = (int)(groupe.Select(x => x.Kilometrage).Sum())
                        };

            return View("StatsVille", query);
        }
    }
}
