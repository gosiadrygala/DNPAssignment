using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Families;

using Models;

namespace WebFamilies_Assignment.Data.Implementation
{
    public class ImplementationAdultsData : InterfaceAdultsData
    {

        public async Task<List<Adult>> GetAllAdults() {

            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:5004/Adult");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            string result = await responseMessage.Content.ReadAsStringAsync();

            List<Adult> adultsCopy = JsonSerializer.Deserialize<List<Adult>>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            return adultsCopy;
        }
        

        public async Task AddAnAdult(Adult adult)
        {
            HttpClient client = new HttpClient();

            string adultAsJson = JsonSerializer.Serialize(adult);

            StringContent content = new StringContent(
                adultAsJson,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage responseMessage = await client.PostAsync("https://localhost:5004/Adult", content);
            
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

        }

        public async void RemoveAnAdult(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.DeleteAsync($"https://localhost:5004/Adult/{id}");
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }
    }
}