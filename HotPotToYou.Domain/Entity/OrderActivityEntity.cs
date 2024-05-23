using HotPotToYou.Domain.Entity.ConfigTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Domain.Entity
{
    [Table("OrderActivity")]
    public class OrderActivityEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public int OrderID { get; set; }
        [ForeignKey(nameof(OrderID))]
        public virtual OrderEntity Order { get; set; }
        public int ActivityTypeID { get; set; }
        [ForeignKey(nameof(ActivityTypeID))]
        public virtual ActivityTypeEntity ActivityType { get; set; }
    }
}
