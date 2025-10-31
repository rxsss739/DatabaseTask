using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Grades
    {
        [Key]
        public Guid Id { get; set; }
        public int Grade {  get; set; }
        public DateTime EntryDate { get; set; }
    }
}
