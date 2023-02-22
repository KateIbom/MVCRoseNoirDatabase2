using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRoseNoirDatabase.Models
{
    public enum AddressTypes { Home, Office, PaymentCard, Other}

    /// <summary>
    /// Used to store customers delivery address associated with the payment card
    /// Author: Kate Ibom
    /// Date: 08/08/2022
    /// </summary>
    
    public class Address
    {
        public int AddressId { get; set; }

        [Display(Name = "Address Type")]
        public AddressTypes AddressType { get; set; }

        [Required, StringLength(5)]

        [Display(Name = "House Number")]
        public string HouseNumber { get; set; } = string.Empty;

        [Required, StringLength(20)]

        public string Street { get; set; } = string.Empty;

        [Required, StringLength(20)]

        public string District { get; set; } = string.Empty;

        [Required, StringLength(20)]
        public string City { get; set; } = string.Empty;

        [Required, StringLength(20)]

        public string County { get; set; } = string.Empty;

        [Required, StringLength(8)]

        [Display(Name = "Post Code")]
        public string PostCode { get; set; } = string.Empty;


        

        
    }
}
