using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Domain.Entity
{
    [Table("Order")]
    public class OrderEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int UserID { get; set; }
        public string Adress { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public int PaymentId { get; set; }
        public string PaymentStatus { get; set; }

    }
}
