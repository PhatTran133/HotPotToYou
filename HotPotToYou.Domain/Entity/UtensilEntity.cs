﻿using HotPotToYou.Domain.Entity.Base;
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
    [Table("Utensil")]
    public class UtensilEntity : EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        
        public string Name { get; set; }
        public string Material {  get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Price { get; set; }

        public virtual HotPotUtensilTypeEntity HotPotUtensilType { get; set; }
        public virtual UtensilDetailEntity UtensilDetail { get; set; }
        public virtual OrderUtensilEntity OrderUtensil { get; set; }
    }
}
