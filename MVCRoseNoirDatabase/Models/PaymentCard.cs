//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace MVCRoseNoirDatabase.Models
{
    public enum PaymentBanks { Tesco, Nationwide, Barclays, HSBC, NatWest }

    public enum PaymentTypes { PayPal, GooglePay, CreditCard, DebitCard }

    public class PaymentCard
    {
        public int PaymentCardId { get; set; }

        public PaymentTypes PaymentType { get; set; } = PaymentTypes.DebitCard;

         
        public PaymentBanks Bank { get; set; }

        [Required, StringLength(50)]
        public string CardNumber { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string NameOnCard { get; set; } = string.Empty;

        [Range(2023, 2027)]
        public int ExpiryYear { get; set; } = 0;

        [Range(1, 12)]
        public int ExpiryMonth { get; set; } = 0;

    }
}
