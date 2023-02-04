﻿namespace MVCRoseNoirDatabase.Models
{
    //https://www.larosenoir.co.uk/

    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = string.Empty;

        // Formatted text
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
