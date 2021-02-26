using Entities.Features;
using Entities.Models;
using Microsoft.AspNetCore.WebUtilities;
using RealEstate.Client.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        public async Task CreateAsync(House house)
        {
            var content = JsonSerializer.Serialize(house);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var postResult = await _client.PostAsync("https://localhost:5011/api/houses", bodyContent);
            var postContent = await postResult.Content.ReadAsStringAsync();
            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }
        }

        public async Task DeleteProperty(int id)
        {
            var url = Path.Combine("https://localhost:5011/api/houses", id.ToString());

            var deleteResult = await _client.DeleteAsync(url);
            var deleteContent = await deleteResult.Content.ReadAsStringAsync();
            if (!deleteResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(deleteContent);
            }
        }

        public async Task<PagingResponse<House>> GetProperty(EntityParameters entityParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = entityParameters.PageNumber.ToString(),
                ["searchTerm"] = entityParameters.SearchTerm ?? "",
                ["orderBy"] = entityParameters.OrderBy
            };

            var response = await _client.GetAsync(QueryHelpers.AddQueryString("https://localhost:5011/api/houses", queryStringParam));
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

        public async Task<House> GetPropertyById(string id)
        {
            var url = Path.Combine("https://localhost:5011/api/houses/", id);

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var house = JsonSerializer.Deserialize<House>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return house;
        }
        public async Task UpdateProperty(House house)
        {
            var content = JsonSerializer.Serialize(house);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var url = Path.Combine("https://localhost:5011/api/houses/", house.Id.ToString());

            var putResult = await _client.PutAsync(url, bodyContent);
            var putContent = await putResult.Content.ReadAsStringAsync();

            if (!putResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(putContent);
            }
        }

    }
}
