using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetCovoiturage.Models;

namespace ProjetCovoiturage.Controllers
{
    public class NotesChauffeursController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NotesChauffeurs
        public ActionResult Index()
        {
            return View(db.NotesChauffeurs.ToList());
        }

        // GET: NotesChauffeurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesChauffeurs notesChauffeurs = db.NotesChauffeurs.Find(id);
            if (notesChauffeurs == null)
            {
                return HttpNotFound();
            }
            return View(notesChauffeurs);
        }

        // GET: NotesChauffeurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotesChauffeurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noteId,chauffeurId,notePonctualitée,noteSecuritée,noteConfort,noteCourtoisie,noteFiabilitée")] NotesChauffeurs notesChauffeurs)
        {
            if (ModelState.IsValid)
            {
                db.NotesChauffeurs.Add(notesChauffeurs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notesChauffeurs);
        }

        // GET: NotesChauffeurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesChauffeurs notesChauffeurs = db.NotesChauffeurs.Find(id);
            if (notesChauffeurs == null)
            {
                return HttpNotFound();
            }
            return View(notesChauffeurs);
        }

        // POST: NotesChauffeurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noteId,chauffeurId,notePonctualitée,noteSecuritée,noteConfort,noteCourtoisie,noteFiabilitée")] NotesChauffeurs notesChauffeurs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notesChauffeurs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notesChauffeurs);
        }

        // GET: NotesChauffeurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotesChauffeurs notesChauffeurs = db.NotesChauffeurs.Find(id);
            if (notesChauffeurs == null)
            {
                return HttpNotFound();
            }
            return View(notesChauffeurs);
        }

        // POST: NotesChauffeurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NotesChauffeurs notesChauffeurs = db.NotesChauffeurs.Find(id);
            db.NotesChauffeurs.Remove(notesChauffeurs);
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
