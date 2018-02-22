using StudentSystem.Interfaces.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace StudentSystem.Repository.Base
{
    //less code = less bugs  :)
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> dbSet;

        public GenericRepository(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
            this.dbSet = this.UnitOfWork.DbContext.Set<TEntity>();
        }

        public IUnitOfWork UnitOfWork { get; set; }

        public IEnumerable<TEntity> GetAllRecords()
        {
            return this.dbSet.ToList();
        }

        public TEntity GetFirstOrDefault(int recordId)
        {
            return this.dbSet.Find(recordId);
        }

        public void Add(TEntity entity)
        {
            this.dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            this.dbSet.Attach(entity);
            this.UnitOfWork.DbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            this.UnitOfWork.SaveChanges();
        }
    }
}