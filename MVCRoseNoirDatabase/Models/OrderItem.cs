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
        public int OrderId { get; set; }
        
        public int ProductOptionId { get; set; }

        public int Quantity { get; set; } = 1;

        public Decimal Price { get; set; }
    }
}
