namespace MVCRoseNoirDatabase.Models
{
    public enum OrderStatus { Payed, Received, Dispatched, Delivered, Returned}

    public enum OrderTypes { Basic, Favour, Hamper}

    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public OrderTypes OrderType { get; set; } = OrderTypes.Basic;

        public OrderStatus Status { get; set; }

        public DateTime DateOrdered { get; set; }

        public DateTime DateDespatched { get; set; }

        public DateTime DateDelivered { get; set; }

        public Decimal DeliveryCharge { get; set; } = 0;

        public int GiftsCount { get; set; } = 0;

        // List of names of people who are going to recieve
        // a Hamper or a Gift as a favour.
        public virtual List<Receiver> Receivers { get; set; }

    }
}
