using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Teacher
    {
        [Key]
        public Guid Id { get; set; }
        public string Email {  get; set; }
        public IEnumerable<Grades> Grades { get; set; } = new List<Grades>();
        public string Name { get; set; }
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
    }
}