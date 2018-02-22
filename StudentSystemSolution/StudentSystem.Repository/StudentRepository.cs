using StudentSystem.Data.Models;
using StudentSystem.Interfaces.Repository;
using StudentSystem.Repository.Base;

namespace StudentSystem.Repository
{
    public class StudentRepository : GenericRepository<Student>, IRepository<Student>, IStudentRepository
    {
        public StudentRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}