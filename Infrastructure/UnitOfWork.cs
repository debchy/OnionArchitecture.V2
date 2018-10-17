using DomainCore.Interfaces;
using Infrastructure;
using DomainCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork
    {
        private DataBaseContext context = new DataBaseContext();

        private IGenericRepository<Domain> domainRepository=null;
        public IGenericRepository<Domain> DomainRepository
        {
            get
            {
                return this.domainRepository ?? new GenericRepository<Domain>(context);
            }
        }

        private IGenericRepository<Content> contentRepository = null;
        public IGenericRepository<Content> ContentRepository
        {
            get
            {
                return this.contentRepository ?? new GenericRepository<Content>(context);
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

