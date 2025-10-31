using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Class
    {
        [Key]
        public Guid Id { get; set; }
        public string Identifier { get; set; }
        public int RoomNr { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; } = new List<Teacher>();
        public IEnumerable<Student> Students { get; set; } = new List<Student>(); 
    }
}
