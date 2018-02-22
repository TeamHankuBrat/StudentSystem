using StudentSystem.BusinessServices;
using StudentSystem.Data.Models;
using StudentSystem.Interfaces.Repository;
using StudentSystem.Interfaces.Services;
using StudentSystem.Repository;
using StudentSystem.Repository.Base;

namespace TestApp
{
    public class Startup
    {
        public static void Main()
        {          
            IUnitOfWork unitOfWork = new UnitOfWork();
            IStudentRepository studentRepository = new StudentRepository(unitOfWork);
            IStudentService studentService = new StudentService(studentRepository);

            Student student = new Student { FirstName = "Pesho", LastName = "Peshov" };

            studentService.AddNewStudent(student);

            studentService.SaveChanges();
        }
    }
}