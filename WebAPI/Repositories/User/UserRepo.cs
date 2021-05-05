using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using WebAPI.DataAccess;

namespace WebAPI.Repositories
{
    public class UserRepo : IUserRepo
    {
        public async Task<User> ValidateUser(User user)
        {
            using (FamilyDBContext familyDbContext = new FamilyDBContext())
            {
                User user1 = await familyDbContext.Users.FirstOrDefaultAsync(u => u.Username.Equals(user.Username));
                return user1;
            }
        }
    }
}