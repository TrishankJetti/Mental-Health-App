using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{
    public enum ProductCategory
    {
        TherapyTools,       //0 
        Books,              //1
        WellnessKits,       //2
        Meditation,         //3
        Journals,           //4
        StressRelief,       //5
        Other               //6
    }

    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 10000, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        [NotMapped]
        [FileExtensions(Extensions = "jpg,jpeg,png,gif", ErrorMessage = "Only image files are allowed")]
        public IFormFile? ImageFile { get; set; }

        public bool IsPrivate { get; set; } = false;

        [Required(ErrorMessage = "Category is required")]
        public ProductCategory Category { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now; // Default value of Right now, with Date and Time.
    }
}
