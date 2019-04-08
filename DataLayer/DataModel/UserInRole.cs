using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataModel
{
    [Table("UserInRole")]
    public class UserInRole
    {
        [Key]
        public int UserInRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime HireDate { get; set; }
        public virtual User Users { get; set; }
    }
}
