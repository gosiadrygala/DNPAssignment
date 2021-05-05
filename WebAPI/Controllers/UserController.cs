using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using WebAPI.Repositories;


namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase{
        
        
        private IUserRepo userRepo = new UserRepo();
        
        [HttpPost]
        public async Task<ActionResult<User>> ValidateUser([FromBody] User loginUser)
        {
            try
            {
                User loginAttempt = await userRepo.ValidateUser(loginUser);
                
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