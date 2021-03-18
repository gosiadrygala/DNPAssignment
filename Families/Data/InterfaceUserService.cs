using Models;

namespace Families
{
    public interface InterfaceUserService
    {
        User ValidateUserLogin(string Username, string Password);
    }
}