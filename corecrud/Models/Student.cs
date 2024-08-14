using System.ComponentModel.DataAnnotations;

namespace corecrud.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
    }
}
