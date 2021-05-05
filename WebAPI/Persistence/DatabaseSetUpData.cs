using System.Collections.Generic;
using System.Linq;
using Models;
using WebAPI.DataAccess;

namespace FileData
{
    public class DatabaseSetUpData
    {
        private static FileContext fileContext = new FileContext();

        public static void LoadChildrenData()
        {
            IList<Family> families = fileContext.Families;
            List<Child> children = new List<Child>();
            foreach (var item in families)
            {
                children.AddRange(item.Children);
            }
            
            using (FamilyDBContext lb = new FamilyDBContext())
            {
                lb.Children.AddRangeAsync(children);
                lb.SaveChanges();
            }
            
        }
        public static void LoadAdultData()
        {
            IList<Adult> adults = fileContext.Adults;
            
            using (FamilyDBContext lb = new FamilyDBContext())
            {
                lb.Adults.AddRangeAsync(adults);
                lb.SaveChanges();
            }
            
        }
        public static void LoadUserData()
        {
            List<User> users = new[]
            {
                new User()
                {
                    Username = "Gosia",
                    Password = "1234",
                    Role = "Administrator", 
                    BirthYear = 1998,
                    SecurityLevel = 5

                },
                new User()
                {
                    Username = "SomeoneSecret",
                    Password = "VerySecretPassword",
                    Role = "Normal user", 
                    BirthYear = 1979,
                    SecurityLevel = 2
                },
                new User()
                {
                    Username = "Anonymouse",
                    Password = "YouWouldNeverExpectSuchPassword",
                    Role = "Someone between admin and normal user", 
                    BirthYear = 1560,
                    SecurityLevel = 3
                } }.ToList();
            using (FamilyDBContext lb = new FamilyDBContext())
            {
                lb.Users.AddRangeAsync(users);
                lb.SaveChanges();
            }
        }
    }
}