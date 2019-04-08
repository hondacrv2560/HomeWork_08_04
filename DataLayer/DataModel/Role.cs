using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataModel
{
    [Table("Role")]
    public class Role
    {
        [Key]
        [Column("RoleId")]
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        [Required]
        [MaxLength(50)]
        [Column("RoleName")]
        public string RoleName { get; set; }
        [Column("Description")]
        public string Description { get; set; }

        public virtual List<UserInRole> UserInRoles { get; set; }

        public Role()
        {
            UserInRoles = new List<UserInRole>();
        }

    }
}
