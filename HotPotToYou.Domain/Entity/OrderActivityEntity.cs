using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Domain.Entity
{
    [Table("OrderActivity")]
    public class OrderActivityEntity
    {
        public int OrderID { get; set; }
        public int TypeID { get; set; }
    }
}
