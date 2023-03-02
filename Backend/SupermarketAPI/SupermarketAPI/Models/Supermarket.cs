using System.ComponentModel.DataAnnotations;

namespace SupermarketAPI.Models
{
    public class Supermarket
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The name can't be bigger than 50 characters")]
        public string Name { get; set; }

        [Required]
        public string State { get; set; }
        
        public string City { get; set; }

        [Required]
        public bool HasLactoseFreeProducts { get; set; }

        [Required]
        public bool HasSugarFreeProducts { get; set; }

        [Required]
        public bool HasVeganProducts { get; set; }

        [Required]
        public bool HasGlutenFreeProducts { get; set; }
    }
}
