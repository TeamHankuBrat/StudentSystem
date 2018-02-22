using StudentSystem.Data.Models;
using StudentSystem.Interfaces.Repository;
using StudentSystem.Interfaces.Services;

namespace StudentSystem.BusinessServices
{
    public class StudentService : IStudentService
    {
        private IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public void AddNewStudent(Student newStudent)
        {
            studentRepository.Add(newStudent);
        }

        public void SaveChanges()
        {
            this.studentRepository.SaveChanges();
        }
    }
}