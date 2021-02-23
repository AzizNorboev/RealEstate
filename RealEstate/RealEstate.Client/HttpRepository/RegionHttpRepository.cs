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
    public class RegionHttpRepository : IPropertyHttpRepository<Region>
    {
        private readonly HttpClient _client;


        public RegionHttpRepository(HttpClient client)
        {
            _client = client;
        }

        //public async Task<List<Region>> GetProperty()
        //{
        //    var response = await _client.GetAsync("https://localhost:5011/api/regions");
        //    var content = await response.Content.ReadAsStringAsync();
        //    var regions = JsonSerializer.Deserialize<List<Region>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        //    return regions;
        //}

        public async Task<PagingResponse<Region>> GetProperty(EntityParameters entityParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = entityParameters.PageNumber.ToString()
            };

            var response = await _client.GetAsync(QueryHelpers.AddQueryString("https://localhost:5011/api/regions", queryStringParam));
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var pagingResponse = new PagingResponse<Region>
            {
                Items = JsonSerializer.Deserialize<List<Region>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }),
                MetaData = JsonSerializer.Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
            };

            return pagingResponse;
        }
    }
}
