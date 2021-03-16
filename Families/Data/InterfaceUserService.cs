using Models;

namespace WebFamilies_Assignment.Data
{
    public interface InterfaceUserService
    {
        User ValidateUserLogin(string Username, string Password);
    }
}