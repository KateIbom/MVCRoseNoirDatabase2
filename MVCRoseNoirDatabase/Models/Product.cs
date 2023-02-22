using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCRoseNoirDatabase.Models
{
    //https://www.larosenoir.co.uk/

    public class Product
    {
        public int ProductId { get; set; }

        [Required, StringLength(80), DisplayName("Option Name")]
        public string Name { get; set; } = string.Empty;

        // Formatted text
        [Required, DisplayName("Description"), DataType(DataType.MultilineText)] 
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Image")]
        public string MainImageUrl { get; set; } = string.Empty;

        public Categories Category { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; } = 0;

        public float Discount { get; set; } = 0;

        [Display(Name="County of Origin")]
        public string CountryOfOrigin { get; set; } = "uk";

        [DataType(DataType.MultilineText)]
        [Display(Name = "Ingredient List")]
        public string IngredientList { get; set; } = string.Empty;

        [DataType(DataType.MultilineText)]

        [Display(Name = "Allergen List")]
        public string AllergenList { get; set; } = string.Empty;

		public virtual List<ProductOption>? Options { get; set; }
    }

}
