﻿using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.DAL
{
    public class UnitOfWork : IDisposable
    {
        private GenericRepository<Chauffeur> chauffeurRepository;
        private GenericRepository<Client> clientRepository;
        private GenericRepository<Trajet> trajetRepository;
        private GenericRepository<Voiture> voitureRepository;
        private GenericRepository<NotesChauffeurs> notesChauffeursRepository;
        private GenericRepository<NotesClient> notesClientsRepository;

        private ApplicationDbContext context = new ApplicationDbContext();

        public UnitOfWork(ApplicationDbContext mockContext)
        {
            context = mockContext;
        }

        public UnitOfWork()
        {
        }

        public GenericRepository<NotesClient> NotesClientsRepository
        {
            get
            {
                if (this.notesClientsRepository == null)
                {
                    this.notesClientsRepository = new GenericRepository<NotesClient>(context);
                }
                return notesClientsRepository;
            }
        }

        public GenericRepository<Chauffeur> ChauffeurRepository
        {
            get
            {
                if (this.chauffeurRepository == null)
                {
                    this.chauffeurRepository = new GenericRepository<Chauffeur>(context);
                }
                return chauffeurRepository;
            }
        }

        public GenericRepository<Client> ClientRepository
        {
            get
            {
                if (this.clientRepository == null)
                {
                    this.clientRepository = new GenericRepository<Client>(context);
                }
                return clientRepository;
            }
        }

        public GenericRepository<Trajet> TrajetRepository
        {
            get
            {
                if (this.trajetRepository == null)
                {
                    this.trajetRepository = new GenericRepository<Trajet>(context);
                }
                return trajetRepository;
            }
        }

        public GenericRepository<Voiture> VoitureRepository
        {
            get
            {
                if (this.voitureRepository == null)
                {
                    this.voitureRepository = new GenericRepository<Voiture>(context);
                }
                return voitureRepository;
            }
        }
        public GenericRepository<NotesChauffeurs> NotesChauffeursRepository
        {
            get
            {
                if (this.notesChauffeursRepository == null)
                {
                    this.notesChauffeursRepository = new GenericRepository<NotesChauffeurs>(context);
                }
                return notesChauffeursRepository;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}