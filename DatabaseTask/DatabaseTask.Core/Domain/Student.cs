using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string IDCode { get; set; }
        public string Email { get; set; }

        public IEnumerable<Grades> Grade { get; set; } = new List<Grades>();


        //public IEnumerable<Children> Childrens { get; set; } = new List<Children>();
    }
}

