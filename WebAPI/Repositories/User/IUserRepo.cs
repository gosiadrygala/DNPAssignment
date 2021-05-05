using System.Threading.Tasks;
using Models;

namespace WebAPI.Repositories
{
    public interface IUserRepo
    {
        Task<User> ValidateUser(User user);
    }
}