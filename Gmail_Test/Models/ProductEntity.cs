using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{
    public class ProductEntity
    {

        public int Id { get; set; }

        public string Product {  get; set; }

        public long Rate { get; set; }

        public long Quantity { get; set; }

        public string ImagePath { get; set; }

        [NotMapped]
        public IFormFile? ProductImage { get; set; }


        // New property to track selection
        public bool IsSelected { get; set; }
    }
}
