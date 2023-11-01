using System.ComponentModel.DataAnnotations;

namespace Web1.Models
{
    public class Person
    {
        [Key]
        public int Idx { get; set; }

        [Required]
        [MaxLength(20)]
        public string Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public string Pass { get; set; }
    }
}
