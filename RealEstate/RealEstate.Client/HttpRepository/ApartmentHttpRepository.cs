using Entities.Features;
using Entities.Models;
using RealEstate.Client.Features;
using Microsoft.AspNetCore.WebUtilities;
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

    

        //public async Task<List<Apartment>> GetProperty()
        //{
        //    var response = await _client.GetAsync("https://localhost:5011/api/apartments");
        //    var content = await response.Content.ReadAsStringAsync();
        //    var apartments = JsonSerializer.Deserialize<List<Apartment>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        //    return apartments;
        //}

        public async Task<PagingResponse<Apartment>> GetProperty(EntityParameters entityParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = entityParameters.PageNumber.ToString()
            };

            var response = await _client.GetAsync(QueryHelpers.AddQueryString("https://localhost:5011/api/apartments", queryStringParam));
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var pagingResponse = new PagingResponse<Apartment>
            {
                Items = JsonSerializer.Deserialize<List<Apartment>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }),
                MetaData = JsonSerializer.Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
            };

            return pagingResponse;
        }
    }
}
