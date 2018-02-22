using StudentSystem.Data.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace StudentSystem.Data
{
    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext()
            :base("name=StudentSystemSQLServer")
        {
        }

        public IDbSet<Student> Student { get; set; }
    }
}