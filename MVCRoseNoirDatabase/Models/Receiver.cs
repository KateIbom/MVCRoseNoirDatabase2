namespace MVCRoseNoirDatabase.Models
{
    public class Receiver
    {
        public int ReceiverId { get; set; }

        public string ReceiverName { get; set; } = String.Empty;

        public string Message { get; set; } = String.Empty;
    }
    
}
