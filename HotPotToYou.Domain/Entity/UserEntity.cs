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
    [Table("User")]
    public class UserEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [ForeignKey(nameof(Customer))]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public int RoleID { get; set; }
        [ForeignKey(nameof(RoleID))]
        public virtual RoleEntity Role { get; set; }

        public virtual CustomerEntity Customer { get; set; }
    }
}
