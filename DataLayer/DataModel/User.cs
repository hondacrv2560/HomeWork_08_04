using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataModel
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column("UserId")]
        public int UserId { get; set; }
        //[ForeignKey("UserId")]
        [Required]
        [MaxLength(50)]
        [Column("Email")]
        public string Email { get; set; }
        [Required]
        [MaxLength(50), MinLength(3)]
        [Column("UserName")]
        public string UserName { get; set; }
        [Column("DateBirthday")]
        public DateTime DateBirthday { get; set; }
        [Column("JobTitleId")]
        public int? JobTitleId { get; set; }

        public virtual List<UserInRole> UserInRoles { get; set; }

        public User()
        {
            UserInRoles = new List<UserInRole>();
        }
    }
}
