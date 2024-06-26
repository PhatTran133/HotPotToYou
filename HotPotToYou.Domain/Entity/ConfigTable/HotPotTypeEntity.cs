﻿using HotPotToYou.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Domain.Entity.ConfigTable
{
    [Table("HotPotType")]
    public class HotPotTypeEntity:BangMaGocEntity
    {
        public virtual ICollection<HotPotEntity> HotPot { get; set; }
        public virtual HotPotUtensilTypeEntity HotPotUtensilType { get; set; }
    }
}
