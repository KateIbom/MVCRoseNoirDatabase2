using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRoseNoirDatabase.Models
{
    public enum PhoneNumberTypes {Home, Mobile, Work, Other }

    /// <summary>
    /// Used to store currrent number assocated with the customer
    /// Author: Kate Ibom
    /// Date: 08/08/2020
    /// </summary>
    public class PhoneNumber
    {
        [Key]
        public int PhoneNumberId { get; set; }

        [Required, StringLength (3)]
        public string InternationalCode { get; set; } = string.Empty;

        [Required, StringLength(3), DataType(DataType .PhoneNumber )]
        public string AreaCode { get; set; } =  string.Empty ;

        public string Number { get; set; } = string.Empty;
    }
}
