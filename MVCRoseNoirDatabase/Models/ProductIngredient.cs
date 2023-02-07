using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRoseNoirDatabase.Models
{
    public enum FragrenceNotes { None, Base, Middle, Top }

    public class ProductIngredient
    {
        [Key]
        public int ProductId { get; set; }
        [Key]
        public string IngredientId { get; set; }

        public FragrenceNotes Note { get; set; } = FragrenceNotes.None;

        public int Percentage { get; set; }

    }
}
