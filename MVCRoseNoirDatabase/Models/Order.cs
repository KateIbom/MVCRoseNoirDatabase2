using System.ComponentModel.DataAnnotations;

namespace MVCRoseNoirDatabase.Models
{
    public enum OrderStatus { Payed, Received, Dispatched, Delivered, Returned}
    

    public enum OrderTypes { Basic, Favour, Hamper}

    public class Order
    {
        [Display(Name = "Order")]
        public int OrderId { get; set; }

        [Display(Name = "Customer")]
        public int CustomerId { get; set; }

        [Display(Name = "Order Type")]

        public OrderTypes OrderType { get; set; } = OrderTypes.Basic;

        public OrderStatus Status { get; set; }

        [Display(Name = "Date Ordered")]

        public DateTime DateOrdered { get; set; }

        [Display(Name = "Despatch Date")]

        public DateTime DateDespatched { get; set; }

        [Display(Name = "Delivery Date")]

        public DateTime DateDelivered { get; set; }

        [Display(Name = "Delivery Charge")]

        public Decimal DeliveryCharge { get; set; } = 0;

        [Display(Name = "Discount")]

        public int GiftsCount { get; set; } = 0;

        // List of names of people who are going to recieve
        // a Hamper or a Gift as a favour.
        public virtual List<Receiver> Receivers { get; set; }

    }
}
