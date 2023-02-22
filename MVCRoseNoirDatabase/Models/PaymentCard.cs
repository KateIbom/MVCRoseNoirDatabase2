//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace MVCRoseNoirDatabase.Models
{
    public enum PaymentBanks { Tesco, Nationwide, Barclays, HSBC, NatWest }

    public enum PaymentTypes { PayPal, GooglePay, CreditCard, DebitCard }

    public class PaymentCard
    {
        [Display(Name = "Payment Card")]
        public int PaymentCardId { get; set; }

        [Display(Name = "Payment Type")]
        public PaymentTypes PaymentType { get; set; } = PaymentTypes.DebitCard;

         
        public PaymentBanks Bank { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; } = string.Empty;

        [Required, StringLength(50)]

        [Display(Name = "Name on the Card")]
        public string NameOnCard { get; set; } = string.Empty;

        [Range(2023, 2027)]

        [Display(Name = "Expiry Year")]
        public int ExpiryYear { get; set; } = 0;

        [Range(1, 12)]

        [Display(Name = "Expiry Month")]
        public int ExpiryMonth { get; set; } = 0;

    }
}
