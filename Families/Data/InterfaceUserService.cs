using System.Threading.Tasks;
using Models;

namespace Families
{
    public interface InterfaceUserService
    {
        Task<User> ValidateUserLogin(string Username, string Password);
    }
}