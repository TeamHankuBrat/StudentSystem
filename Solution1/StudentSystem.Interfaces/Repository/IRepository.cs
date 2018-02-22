using System.Collections.Generic;

namespace StudentSystem.Interfaces.Repository
{
    public interface IRepository <TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllRecords();

        TEntity GetFirstOrDefault(int recordId);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void SaveChanges();
    }
}