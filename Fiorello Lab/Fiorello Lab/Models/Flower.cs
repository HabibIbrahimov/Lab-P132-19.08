using System.ComponentModel.DataAnnotations;

namespace Fiorello_Lab.Models
{
    public class Flower
    {
        public int Id { get; set; }
        [MaxLength(80)]
        public string? Name { get; set; }
        public double Price { get; set; }
        [MaxLength(100)]
        public string? ImgUrl { get; set; }
        [Required]
        public int? CategorieId { get; set; }

        public Categorie? Categorie { get; set; }

    }
}
