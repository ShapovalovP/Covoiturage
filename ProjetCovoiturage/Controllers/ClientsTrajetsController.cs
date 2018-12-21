using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ProjetCovoiturage.Models;

namespace ProjetCovoiturage.Controllers
{
    public class ClientsTrajetsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ClientsTrajets
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            Client client = db.Clients.Where(x => x.UserId == userId).FirstOrDefault();

            if (client == null)
            {
                List<ClientsTrajets> ct = new List<ClientsTrajets>();
                return View(ct);
            }
            var clientTrajets = db.ClientTrajets.Where(x=>x.Client_ClientID == client.ClientID).Include(c => c.client).Include(c => c.trajet);
            return View(clientTrajets.ToList());
        }

        public ActionResult Payer(int? idClient, int? idTrajet)
        {

            ClientsTrajets changer = db.ClientTrajets.Where(x => x.Client_ClientID == idClient && x.Trajet_Id == idTrajet).FirstOrDefault();
            changer.IsPayed = true;
            db.Entry(changer).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ClientsTrajets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientsTrajets clientsTrajets = db.ClientTrajets.Find(id);
            if (clientsTrajets == null)
            {
                return HttpNotFound();
            }
            return View(clientsTrajets);
        }

        // GET: ClientsTrajets/Create
        public ActionResult Create()
        {
            ViewBag.Client_ClientID = new SelectList(db.Clients, "ClientID", "UserId");
            ViewBag.Trajet_Id = new SelectList(db.Trajets, "Id", "VilleDepart");
            return View();
        }

        // POST: ClientsTrajets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Client_ClientID,Trajet_Id")] ClientsTrajets clientsTrajets)
        {
            if (ModelState.IsValid)
            {
                db.ClientTrajets.Add(clientsTrajets);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Client_ClientID = new SelectList(db.Clients, "ClientID", "UserId", clientsTrajets.Client_ClientID);
            ViewBag.Trajet_Id = new SelectList(db.Trajets, "Id", "VilleDepart", clientsTrajets.Trajet_Id);
            return View(clientsTrajets);
        }

        // GET: ClientsTrajets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientsTrajets clientsTrajets = db.ClientTrajets.Find(id);
            if (clientsTrajets == null)
            {
                return HttpNotFound();
            }
            ViewBag.Client_ClientID = new SelectList(db.Clients, "ClientID", "UserId", clientsTrajets.Client_ClientID);
            ViewBag.Trajet_Id = new SelectList(db.Trajets, "Id", "VilleDepart", clientsTrajets.Trajet_Id);
            return View(clientsTrajets);
        }

        // POST: ClientsTrajets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Client_ClientID,Trajet_Id")] ClientsTrajets clientsTrajets)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientsTrajets).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Client_ClientID = new SelectList(db.Clients, "ClientID", "UserId", clientsTrajets.Client_ClientID);
            ViewBag.Trajet_Id = new SelectList(db.Trajets, "Id", "VilleDepart", clientsTrajets.Trajet_Id);
            return View(clientsTrajets);
        }

        // GET: ClientsTrajets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientsTrajets clientsTrajets = db.ClientTrajets.Find(id);
            if (clientsTrajets == null)
            {
                return HttpNotFound();
            }
            return View(clientsTrajets);
        }

        // POST: ClientsTrajets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClientsTrajets clientsTrajets = db.ClientTrajets.Find(id);
            db.ClientTrajets.Remove(clientsTrajets);
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
