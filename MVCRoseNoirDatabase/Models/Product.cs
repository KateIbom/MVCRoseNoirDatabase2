using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCRoseNoirDatabase.Models
{
    //https://www.larosenoir.co.uk/

    public class Product
    {
        public int ProductId { get; set; }

        [Required, StringLength(50), DisplayName("Option Name")]
        public string Name { get; set; } = string.Empty;

        // Formatted text
        [Required, StringLength(200), DisplayName("Description")] 
        public string Description { get; set; } = string.Empty;

        public string MainImageUrl { get; set; } = string.Empty;

        public Categories Category { get; set; }

        public decimal Price { get; set; } = 0;

        public float Discount { get; set; } = 0;

        public string CountryOfOrigin { get; set; } = "uk";

        public string IngredientList { get; set; } = string.Empty;

		public string AllergenList { get; set; } = string.Empty;

		public virtual List<ProductOption>? Options { get; set; }
    }

}
