using System;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}