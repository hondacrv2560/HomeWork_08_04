using DataLayer;
using DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new UserInit());

            UserContext userContext = new UserContext();

            User user = new User()
            {
                UserId = 20,
                JobTitleId = 1,
                DateBirthday = new DateTime(1993, 8, 12),
                UserName = "vasja",
                Email = "vasja@mathart.com"
            };

            userContext.Users.Add(user);
            userContext.SaveChanges();

        }
    }
}
