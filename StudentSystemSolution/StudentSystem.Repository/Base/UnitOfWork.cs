using StudentSystem.Data;
using StudentSystem.Interfaces.Repository;
using System;

namespace StudentSystem.Repository.Base
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private bool disposed = false;
        private static StudentSystemDbContext dbContext = null;

        //Singleton
        public StudentSystemDbContext DbContext
        {
            get
            {
                if (dbContext == null)
                {
                    dbContext = new StudentSystemDbContext(); 
                }

                return dbContext;
            }
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.DbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}