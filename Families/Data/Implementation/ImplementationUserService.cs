using System;
using System.Collections.Generic;
using System.Linq;
using Families;
using Models;

namespace WebFamilies_Assignment.Data.Implementation
{
    public class ImplementationUserService : InterfaceUserService
    {
        private List<User> users;

        public ImplementationUserService()
        {
            users = new[]
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
                }
            }.ToList();
        }
        
        public User ValidateUserLogin(string Username, string Password)
        {
            User someUser = users.First(user => user.Username.Equals(Username));

            if (someUser == null) throw new Exception("Hey there! " +
                                                      "Unfortunately user was not found *sad sound* ");

            if (!someUser.Password.Equals(Password))
                throw new Exception("Are you trying to hack my web with a wrong password? *sad sound* ");
            
            
            return someUser;
        }
        
    }
}
