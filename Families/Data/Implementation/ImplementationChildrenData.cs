using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Families;
using Models;

namespace WebFamilies_Assignment.Data.Implementation
{
    public class ImplementationChildrenData : InterfaceChildrenData
    {

        public async Task<IList<Child>> GetAllChildren()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:5004/Children");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            string result = await responseMessage.Content.ReadAsStringAsync();

            List<Child> children = JsonSerializer.Deserialize<List<Child>>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
           
            return children;
        }

       
    }
}