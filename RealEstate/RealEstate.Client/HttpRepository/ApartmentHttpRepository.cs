using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RealEstate.Client.HttpRepository
{
    public class ApartmentHttpRepository : IPropertyHttpRepository<Apartment>
    {
        private readonly HttpClient _client;
        

        public ApartmentHttpRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Apartment>> GetProperty()
        {
            var response = await _client.GetAsync("https://localhost:5011/api/apartments");
            var content = await response.Content.ReadAsStringAsync();
            var apartments = JsonSerializer.Deserialize<List<Apartment>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return apartments;
        }
    }
}
