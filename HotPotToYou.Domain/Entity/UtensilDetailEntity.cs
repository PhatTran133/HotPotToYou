using HotPotToYou.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Domain.Entity
{
    [Table("UtensilDetai")]
    public class UtensilDetailEntity : EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public int UtensilID { get; set; }
        [ForeignKey(nameof(UtensilID))]
        public virtual UtensilEntity Utensil { get; set; }
        public int PackageID { get; set; }
        [ForeignKey(nameof(PackageID))]
        public virtual UtensilPackageEntity UtensilPackage { get; set; }
    }
}
