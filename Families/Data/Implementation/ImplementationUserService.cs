using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Families;
using Models;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace WebFamilies_Assignment.Data.Implementation
{
    public class ImplementationUserService : InterfaceUserService
    {

        public async Task<User> ValidateUserLogin(string username, string password)
        {

            HttpClient client = new HttpClient();

            User user = new()
            {
                Username = username,
                Password = password
            };

            string userAsJson = JsonSerializer.Serialize(user);

            StringContent content = new StringContent(
                userAsJson, Encoding.UTF8, "application/json"
            );

            HttpResponseMessage responseMessage = await client.PostAsync("https://localhost:5004/User", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            
            string someUser = await responseMessage.Content.ReadAsStringAsync();

            User finalUser = JsonSerializer.Deserialize<User>(someUser, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            return finalUser;
        }
        
    }
}
