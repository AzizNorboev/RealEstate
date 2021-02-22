using Entities.Features;
using Entities.Models;
using Microsoft.AspNetCore.WebUtilities;
using RealEstate.Client.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RealEstate.Client.HttpRepository
{
    public class HouseHttpRepository : IPropertyHttpRepository<House>
    {
        private readonly HttpClient _client;


        public HouseHttpRepository(HttpClient client)
        {
            _client = client;
        }


        //public async Task<List<House>> GetProperty()
        //{
        //    var response = await _client.GetAsync("https://localhost:5011/api/houses");
        //    var content = await response.Content.ReadAsStringAsync();
        //    var houses = JsonSerializer.Deserialize<List<House>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        //    return houses;
        //}

        public async Task<PagingResponse<House>> GetProperty(EntityParameters entityParameters)
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

            var pagingResponse = new PagingResponse<House>
            {
                Items = JsonSerializer.Deserialize<List<House>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }),
                MetaData = JsonSerializer.Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
            };

            return pagingResponse;
        }
    }
}
