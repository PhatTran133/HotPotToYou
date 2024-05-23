using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Domain.Entity
{
    [Table("HotPotPackage")]

    public class HotPotPackageEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public virtual OrderEntity Order { get; set; }
        public int HotPotID { get; set; }
        [ForeignKey(nameof(HotPotID))]
        public virtual HotPotEntity HotPot { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Total {  get; set; }
    }
}
