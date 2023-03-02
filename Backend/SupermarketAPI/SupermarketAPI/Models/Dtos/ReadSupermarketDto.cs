using System.ComponentModel.DataAnnotations;

namespace SupermarketAPI
{
    public class ReadSupermaketDto
    {
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