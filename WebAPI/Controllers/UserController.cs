using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase{
        
        private List<User> users;

        public UserController()
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


        [HttpPost]
        public async Task<ActionResult<User>> ValidateUser([FromBody] User loginUser)
        {
            try
            {
                User loginAttempt = users.First(user => user.Username.Equals(loginUser.Username));

                if (loginAttempt == null)
                    return StatusCode(404, "Hey there! " +
                                           "Unfortunately user was not found *sad sound* ");

                if (!loginAttempt.Password.Equals(loginUser.Password))
                    return StatusCode(404, "Are you trying to hack my web with a wrong password? *sad sound* ");

                return Ok(loginAttempt);
            }
            catch(Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}