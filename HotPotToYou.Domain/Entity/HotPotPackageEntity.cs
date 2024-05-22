using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Domain.Entity
{
    [Table("HotPotPackage")]

    public class HotPotPackageEntity
    {
        public int OrderId { get; set; }
        public int HotPotID { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Total {  get; set; }
    }
}
