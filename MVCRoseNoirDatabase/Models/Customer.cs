using System.ComponentModel.DataAnnotations;

namespace MVCRoseNoirDatabase.Models
{
    /// <summary>
    /// This class is used to store the essential commnication
    /// details of a registered customer.
    /// </summary>
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        // Needs to match name on payment card or method
        [StringLength(30), Required, Display(Name ="First Name")]
        public string FirstName { get; set; } = string.Empty;

        // Needs to match name on payment card or method
        [StringLength(30), Required, Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        // Needs to match the email address used to register an account
        [StringLength(128), Required]
        public string Email { get; set; } = string.Empty ;

        [StringLength(15), DataType(DataType.PhoneNumber)]
        public string HomeNumber { get; set; } = string.Empty;

        [Required, StringLength (15),DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; } = string.Empty;

        // Navigation Properties
        public virtual List <Address> Addresses { get; set; }

       // public virtual List <PhoneNumber> PhoneNumbers { get; set; } 

        public virtual List<PaymentCard> PaymentCards { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
