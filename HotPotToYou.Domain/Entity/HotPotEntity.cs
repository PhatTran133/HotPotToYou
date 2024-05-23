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
    [Table("HotPot")]
    public class HotPotEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Price { get; set; }
        public int TypeID { get; set; }
        [ForeignKey(nameof(TypeID))]
        public virtual HotPotTypeEntity HotPotType { get; set; }
        public virtual HotPotPackageEntity HotPotPackage { get; set; }
        public virtual HotPotIngredientEntity HotPotIngredient { get; set; }
    }
}
