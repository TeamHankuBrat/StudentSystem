using StudentSystem.Data.Models;

namespace StudentSystem.Interfaces.Services
{
    public interface IStudentService
    {
        void AddNewStudent(Student newStudent);
        void SaveChanges();
    }
}