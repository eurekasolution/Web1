using System.ComponentModel.DataAnnotations;

namespace Web1.Models
{
    public class User
    {
        [MaxLength(20)]
        public int Idx { get; set; }

        [Required]
        [MaxLength(20)]
        public string Id {  get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Pass { get; set; }

    }
}
