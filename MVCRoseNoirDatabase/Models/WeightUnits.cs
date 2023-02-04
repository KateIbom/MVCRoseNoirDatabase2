using System.ComponentModel.DataAnnotations;

namespace MVCRoseNoirDatabase.Models
{
	public enum WeightUnits
	{
		[Display(Name ="Grams")]
		g,
		[Display(Name = "Kilograms")]
		kg
	}
}
