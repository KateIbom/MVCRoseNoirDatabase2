using System.ComponentModel.DataAnnotations;

// https://www.healthline.com/nutrition/grapefruit-essential-oil#TOC_TITLE_HDR_6

namespace MVCRoseNoirDatabase.Models
{
    public enum IngredientTypes { other, wax, oil, dye}

    public class Ingredient
    {
        [Key]
        public string Id { get; set; } = String.Empty;

        public IngredientTypes Type { get; set; } = IngredientTypes.other;

        public string Benefits { get; set; } = string.Empty;

        public string Safety { get; set; } = string.Empty;

        public bool PossibleAllergin { get; set; } = false;

        public string InfoUrl { get; set; } = String.Empty;
    }
}
