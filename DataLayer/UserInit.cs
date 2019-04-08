using DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{

    public class UserInit : DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            User u1 = new User
            {
                UserId = 1,
                JobTitleId = 1,
                DateBirthday = new DateTime(1993, 8, 12),
                UserName = "vasja",
                Email = "vasja@mathart.com"
            };
            User u2 = new User
            {
                UserId = 2,
                JobTitleId = 2,
                DateBirthday = new DateTime(1990, 4, 21),
                UserName = "petro",
                Email = "petro@mathart.com"
            };
            User u3 = new User
            {
                UserId = 3,
                JobTitleId = 4,
                DateBirthday = new DateTime(1989, 3, 2),
                UserName = "vanja",
                Email = "vanja@mathart.com"
            };
            User u4 = new User
            {
                UserId = 4,
                JobTitleId = 5,
                DateBirthday = new DateTime(1988, 1, 23),
                UserName = "manja",
                Email = "manja@mathart.com"
            };
            User u5 = new User
            {
                UserId = 12,
                JobTitleId = 6,
                DateBirthday = new DateTime(1994, 11, 13),
                UserName = "dasha",
                Email = "dasha@mathart.com"
            };
            User u6 = new User
            {
                UserId = 13,
                JobTitleId = null,
                DateBirthday = new DateTime(1993, 12, 17),
                UserName = "luba",
                Email = "luba@mathart.com"
            };
            User u7 = new User
            {
                UserId = 7,
                JobTitleId = 2,
                DateBirthday = new DateTime(1991, 4, 1),
                UserName = "luda",
                Email = "luda@mathart.com"
            };
            context.Users.AddRange(new List<User> { u1, u2, u3, u4, u5, u6, u7 });

            Role r1 = new Role
            {
                RoleId = 1,
                RoleName = "administrator"
            };
            Role r2 = new Role
            {
                RoleId = 2,
                RoleName = "manager"
            };
            Role r3 = new Role
            {
                RoleId = 3,
                RoleName = "programmer"
            };
            Role r4 = new Role
            {
                RoleId = 4,
                RoleName = "admin"
            };
            context.Roles.AddRange(new List<Role> { r1, r2, r3, r4 });

            UserInRole uR1 = new UserInRole
            {
                UserInRoleId = 1,
                UserId = 1,
                HireDate = new DateTime(2010, 1, 15),
                RoleId = 1
            };
            UserInRole uR2 = new UserInRole
            {
                UserInRoleId = 2,
                UserId = 1,
                HireDate = new DateTime(2010, 1, 15),
                RoleId = 2
            };
            UserInRole uR3 = new UserInRole
            {
                UserInRoleId = 3,
                UserId = 1,
                HireDate = new DateTime(2012, 6, 15),
                RoleId = 3
            };
            UserInRole uR4 = new UserInRole
            {
                UserInRoleId = 4,
                UserId = 2,
                HireDate = new DateTime(2010, 3, 15),
                RoleId = 2
            };
            UserInRole uR5 = new UserInRole
            {
                UserInRoleId = 5,
                UserId = 3,
                HireDate = new DateTime(2014, 7, 12),
                RoleId = 1
            };
            UserInRole uR6 = new UserInRole
            {
                UserInRoleId = 6,
                UserId = 3,
                HireDate = new DateTime(2013, 10, 1),
                RoleId = 2
            };
            UserInRole uR7 = new UserInRole
            {
                UserInRoleId = 7,
                UserId = 4,
                HireDate = new DateTime(2014, 1, 15),
                RoleId = 3
            };
            UserInRole uR8 = new UserInRole
            {
                UserInRoleId = 8,
                UserId = 12,
                HireDate = new DateTime(2012, 1, 4),
                RoleId = 2
            };
            UserInRole uR9 = new UserInRole
            {
                UserInRoleId = 9,
                UserId = 12,
                HireDate = new DateTime(2013, 11, 2),
                RoleId = 3
            };
            UserInRole uR10 = new UserInRole
            {
                UserInRoleId = 10,
                UserId = 12,
                HireDate = new DateTime(2014, 9, 1),
                RoleId = 1
            };
            UserInRole uR11 = new UserInRole
            {
                UserInRoleId = 11,
                UserId = 7,
                HireDate = new DateTime(2013, 1, 10),
                RoleId = 2
            };
            context.UserInRoles.AddRange(new List<UserInRole> { uR1, uR2, uR3, uR4,
                uR5, uR6, uR7, uR8, uR9, uR10, uR11});
            context.SaveChanges();
        }

    }
    
}
