using _09._10.ApplicationContexts;
using _09._10.Models;
using Microsoft.EntityFrameworkCore;

namespace _09._10
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                List<User> users = new List<User>()
                {
                    new User{Email="ThreeDaysGrace@gmail.com",UserSettings=new UserSettings{Country="USA",City="NewYork"}},
                    new User{Email="Mudveyn@stud.onu.edu.ua",UserSettings=new UserSettings{Country="USA",City="LA"}},
                    new User{Email="NANA@gmail.com",UserSettings=new UserSettings{Country="Japan",City="Tokyo"}},

                };
                db.Users.AddRange(users);
                db.SaveChanges();
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                var currentUser = db.Users.Include(e => e.UserSettings).FirstOrDefault();
                var user2 = db.Users.FirstOrDefault(e => e.Id == 2);

                var user3 = db.Users.FirstOrDefault(u => u.Id == 3);
                if (user3 != null)
                {
                    db.Users.Remove(user3);
                    db.SaveChanges();
                }
            }
        }
    }

    

    

    
}
