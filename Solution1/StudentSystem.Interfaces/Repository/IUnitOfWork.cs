using StudentSystem.Data;

namespace StudentSystem.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        StudentSystemDbContext DbContext { get; }
        void SaveChanges();
    }
}