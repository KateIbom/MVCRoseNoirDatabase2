using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVCRoseNoirDatabase.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Order Id")]

        public int OrderId { get; set; }

        [Display(Name = "Product Option")]

        public int ProductOptionId { get; set; }

        [Range (0,12)]

        public int Quantity { get; set; } = 1;

        [Range(0,200)]

        [DataType(DataType.Currency)]

        public Decimal Price { get; set; }
    }
}
