using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCRoseNoirDatabase.Models
{
    /// <summary>
    /// A product option or variation for example
    /// different colours or sizes.  Also used to
    /// list all the ingredients or allergies in a
    /// product, see OptionType.
    /// </summary>
    public class ProductOption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        // The main product
        public int ProductId { get; set; }

        // e.g. the name of a colour, or the size
        [Required,StringLength(50),DisplayName("Option Name")]
        public string Name { get; set; } = string.Empty;
        
        // short description if needed
        [Required, StringLength(400)]
        public string Description { get; set;} = string.Empty;
        
        public string ImageUrl { get; set; } = string.Empty;

        // Alternative option price if not the same as the main product
        public decimal Price { get; set; } = 0;

        // Stock Control
        [Display (Name = "IS")]
        public int IncomingStock { get; set; } = 0;

        [Display(Name = "AS")]
        public int AvailableStock { get; set; } = 1;

        [Display(Name = "CS")]
        public int ComittedStock { get; set; } = 0;

        // is this needed ??
        public int Size { get; set; } = 0;

        [Display(Name = "Size Units")]
        public SizeUnits SizeUnit { get; set; } = SizeUnits.cl;

        public float Weight { get; set; } = 0;

        [Display(Name = "Units")]
        public WeightUnits WeightUnit { get; set; } = WeightUnits.g;

        [Display(Name = "Type")]
        public OptionTypes OptionType {get; set;}

        public float Discount { get; set; } = 0;

        // NAVIGATION PROPERTY
        public virtual Product Product { get; set; }
    }
}
