namespace ProjetCovoiturage.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ProjetCovoiturage.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetCovoiturage.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false; /////dobavil
            ContextKey = "ProjetCovoiturage.Models.ApplicationDbContext";
        }

        protected override void Seed(ProjetCovoiturage.Models.ApplicationDbContext context)
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context)); ////dobavil
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            List<Chauffeur> chauffeurs = new List<Chauffeur>()
            {
                new Chauffeur { Nom = "Mc", Prenom = "Donald", NumeroPermis= "123456789", NumeroTelephone = 438911911, Ville= "Montreal",
                    DatePermis = new DateTime(2010,01,01), DateEmbauche = new DateTime(2015,01,01) , Email= "a@a.com",Public=true },
                 new Chauffeur { Nom = "Max", Prenom = "Degouet", NumeroPermis= "987654321", NumeroTelephone = 450911911, Ville= "Toronto",
                    DatePermis = new DateTime(2011,01,01), DateEmbauche = new DateTime(2014,01,01) , Email= "a@b.com",Public=false }
            };

            List<Client> clients = new List<Client>()
            {
                new Client { ClientID = 1, ClientNom = "Peuplu", ClientPrenom = "Jean", AgeClient = 18, TelephoneClient = "44444", VilleClient = "Iberville" },
                new Client { ClientID = 2, ClientNom = "Peuplu", ClientPrenom = "Jean", AgeClient = 18, TelephoneClient = "44444", VilleClient = "Iberville" }
            };

            Client cl1 = clients[0];
            Client cl2 = clients[1];

            Chauffeur c = chauffeurs[0];
            Chauffeur c2 = chauffeurs[1];

            List<Trajet> trajets = new List<Trajet>()
            {

                new Trajet {Id = 1, Chauffeur = c, HeureDepart = new DateTime(2019,01,01) , HeureArrivee = new DateTime(2019,01,02), Kilometrage = 700,
                    VilleDepart = "Montreal", VilleDestination= "Toronto", PlaceRestante = 4, PointDepart = "college", PointArrivee= "airport", Prix = 50  },
                  new Trajet {Id = 2, Chauffeur = c, HeureDepart = new DateTime(2019,01,11) , HeureArrivee = new DateTime(2019,01,12), Kilometrage = 500,
                    VilleDepart = "Montreal", VilleDestination= "Kingston", PlaceRestante = 3, PointDepart = "port", PointArrivee= "airport", Prix = 20  },
                  new Trajet {Id = 3, Chauffeur = c, HeureDepart = new DateTime(2018,01,11) , HeureArrivee = new DateTime(2018,01,12), Kilometrage = 500,
                    VilleDepart = "Montreal", VilleDestination= "Kingston", PlaceRestante = 3, PointDepart = "port", PointArrivee= "airport", Prix = 20  },
                          new Trajet { Id = 4, Chauffeur = c, HeureDepart = new DateTime(2018,01,01) , HeureArrivee = new DateTime(2018,01,02), Kilometrage = 700,
                    VilleDepart = "Montreal", VilleDestination= "Toronto", PlaceRestante = 3, PointDepart = "college", PointArrivee= "airport", Prix = 20  },

                new Trajet {Id = 5, Chauffeur = c2, HeureDepart = new DateTime(2019,01,01) , HeureArrivee = new DateTime(2019,01,02), Kilometrage = 700,
                    VilleDepart = "Toronto" , VilleDestination= "Montreal", PlaceRestante = 4, PointDepart = "college", PointArrivee= "airport", Prix = 50  },
                  new Trajet {Id = 6, Chauffeur = c2, HeureDepart = new DateTime(2018,01,11) , HeureArrivee = new DateTime(2018,01,12), Kilometrage = 500,
                    VilleDepart = "Kingston", VilleDestination= "Montreal", PlaceRestante = 3, PointDepart = "port", PointArrivee= "airport", Prix = 20  },
                  new Trajet {Id = 7, Chauffeur = c2, HeureDepart = new DateTime(2018,01,11) , HeureArrivee = new DateTime(2018,01,12), Kilometrage = 500,
                    VilleDepart = "Kingston", VilleDestination= "Montreal", PlaceRestante = 3, PointDepart = "port", PointArrivee= "airport", Prix = 20  },
                          new Trajet {Id = 8, Chauffeur = c2, HeureDepart = new DateTime(2018,01,01) , HeureArrivee = new DateTime(2018,01,02), Kilometrage = 700,
                    VilleDepart = "Toronto", VilleDestination= "Montreal", PlaceRestante = 3, PointDepart = "college", PointArrivee= "airport", Prix = 20  },

            };
            List<NotesChauffeurs> notes = new List<NotesChauffeurs>()
            {
                new NotesChauffeurs { chaufeurs = c , noteConfort = 1, noteCourtoisie = 2 , noteFiabilite =3 , notePonctualite =4, noteSecurite =5},
                 new NotesChauffeurs { chaufeurs = c , noteConfort = 5, noteCourtoisie = 4 , noteFiabilite =2 , notePonctualite =3, noteSecurite =1},
                 new NotesChauffeurs { chaufeurs = c , noteConfort = 4, noteCourtoisie = 3 , noteFiabilite =4, notePonctualite =4, noteSecurite =1},
                 new NotesChauffeurs { chaufeurs = c , noteConfort = 3, noteCourtoisie = 1 , noteFiabilite =1 , notePonctualite =3, noteSecurite =1},
                  new NotesChauffeurs { chaufeurs = c , noteConfort = 1, noteCourtoisie = 2 , noteFiabilite =3 , notePonctualite =4, noteSecurite =5},
                 new NotesChauffeurs { chaufeurs = c , noteConfort = 1, noteCourtoisie = 4 , noteFiabilite =2 , notePonctualite =3, noteSecurite =1},
                 new NotesChauffeurs { chaufeurs = c , noteConfort = 1, noteCourtoisie = 5 , noteFiabilite =4, notePonctualite =4, noteSecurite =1},
                 new NotesChauffeurs { chaufeurs = c , noteConfort = 3, noteCourtoisie = 1 , noteFiabilite =1 , notePonctualite =3, noteSecurite =1},

                new NotesChauffeurs { chaufeurs = c2 , noteConfort = 1, noteCourtoisie = 2 , noteFiabilite =3 , notePonctualite =4, noteSecurite =5},
                 new NotesChauffeurs { chaufeurs = c2 , noteConfort = 5, noteCourtoisie = 4 , noteFiabilite =2 , notePonctualite =3, noteSecurite =1},
                 new NotesChauffeurs { chaufeurs = c2 , noteConfort = 4, noteCourtoisie = 5 , noteFiabilite =4, notePonctualite =1, noteSecurite =4},
                 new NotesChauffeurs { chaufeurs = c2 , noteConfort = 3, noteCourtoisie = 1 , noteFiabilite =3 , notePonctualite =3, noteSecurite =1},
                  new NotesChauffeurs { chaufeurs = c2 , noteConfort = 5, noteCourtoisie = 2 , noteFiabilite =3 , notePonctualite =4, noteSecurite =5},
                 new NotesChauffeurs { chaufeurs = c2 , noteConfort = 1, noteCourtoisie = 4 , noteFiabilite =2 , notePonctualite =3, noteSecurite =4},
                 new NotesChauffeurs { chaufeurs = c2 , noteConfort = 5, noteCourtoisie = 5 , noteFiabilite =4, notePonctualite =1, noteSecurite =4},
                 new NotesChauffeurs { chaufeurs = c2 , noteConfort = 3, noteCourtoisie = 1 , noteFiabilite =1 , notePonctualite =3, noteSecurite =1}
            };

            List<NotesClient> notesClients = new List<NotesClient>()
            {
                new NotesClient { clientID = cl1.ClientID, note = 1, trajetID = 8  },
                new NotesClient { clientID = cl2.ClientID, note = 5, trajetID = 3  },
                new NotesClient { clientID = cl1.ClientID, note = 4, trajetID = 2  },
                new NotesClient { clientID = cl2.ClientID, note = 5, trajetID = 1  },
                new NotesClient { clientID = cl1.ClientID, note = 3, trajetID = 5  },
                new NotesClient { clientID = cl1.ClientID, note = 2, trajetID = 8  },
                new NotesClient { clientID = cl2.ClientID, note = 5, trajetID = 6  },
                new NotesClient { clientID = cl1.ClientID, note = 4, trajetID = 2  },
                new NotesClient { clientID = cl2.ClientID, note = 5, trajetID = 1  },
                new NotesClient { clientID = cl1.ClientID, note = 3, trajetID = 5  }
            };

            context.Clients.AddRange(clients);
            context.Chauffeur.AddRange(chauffeurs);
            context.Trajets.AddRange(trajets);
            context.NotesChauffeurs.AddRange(notes);

            context.SaveChanges();

        }
    }
}
