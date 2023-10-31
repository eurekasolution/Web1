using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web1.Models
{
    public class User
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
