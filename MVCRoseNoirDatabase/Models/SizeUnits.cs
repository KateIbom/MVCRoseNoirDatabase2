using System.ComponentModel.DataAnnotations;

namespace MVCRoseNoirDatabase.Models
{
	public enum SizeUnits
	{
		[Display(Name = "millilitres")]
		ml,
		[Display(Name = "centilitres")]
		cl,
		[Display(Name = "litres")]
		ltr
	}
}
