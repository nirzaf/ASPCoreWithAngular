using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPWithAngular.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetails { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }
        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        public string ExpirationDate { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; }
    }
}
