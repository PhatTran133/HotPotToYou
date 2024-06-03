﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotPotToYou.Domain.Entity.ConfigTable;
using HotPotToYou.Domain.Entity.Base;

namespace HotPotToYou.Domain.Entity
{
    [Table("Ingredient")]
    public class IngredientEntity : EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int GroupID { get; set; }
        [ForeignKey(nameof(GroupID))]
        public virtual IngredientGroupEntity IngredientGroup { get; set; }

        public virtual HotPotIngredientEntity HotPotIngredient { get; set; }
    }
}
