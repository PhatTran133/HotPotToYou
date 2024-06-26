﻿using HotPotToYou.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Domain.Entity.ConfigTable
{
    [Table("Payment")]
    public class PaymentEntity:BangMaGocEntity
    {
        public virtual ICollection<OrderEntity> Order { get; set; }
    }
}
