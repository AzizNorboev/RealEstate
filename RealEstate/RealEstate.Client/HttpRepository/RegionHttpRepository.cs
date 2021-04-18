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
    public class RegionHttpRepository : HttpRepositoryBase, IHttpRepository<Region>
    {
        public RegionHttpRepository(HttpClient client)
           : base(client)
    {
    }
        public async Task CreateAsync(Region region)
        {
            var content = JsonSerializer.Serialize(region);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var postResult = await _client.PostAsync("https://localhost:5021/api/regions", bodyContent);
            var postContent = await postResult.Content.ReadAsStringAsync();
            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var url = Path.Combine("https://localhost:5021/api/regions", id.ToString());

            var deleteResult = await _client.DeleteAsync(url);
            var deleteContent = await deleteResult.Content.ReadAsStringAsync();
            if (!deleteResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(deleteContent);
            }
        }

        //passing an entire URI to the server endpoint
        public async Task<PagingResponse<Region>> GetAll(EntityParameters entityParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = entityParameters.PageNumber.ToString()
            };

            var response = await _client.GetAsync(QueryHelpers.AddQueryString("https://localhost:5021/api/regions", queryStringParam));
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

        public async Task<Region> GetById(string id)
        {
            var url = Path.Combine("https://localhost:5021/api/regions/", id);

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var region = JsonSerializer.Deserialize<Region>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return region;
        }

        public async Task UpdateAsync(Region entity)
        {
            var content = JsonSerializer.Serialize(entity);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var url = Path.Combine("https://localhost:5021/api/regions/", entity.Id.ToString());

            var putResult = await _client.PutAsync(url, bodyContent);
            var putContent = await putResult.Content.ReadAsStringAsync();

            if (!putResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(putContent);
            }
        }

        /// <summary>
        /// In case if such property will be added)
        /// </summary>
        /// <param name="wont be used probably"></param>
        /// <returns>nothing</returns>
        public async Task<string> UploadImage(MultipartFormDataContent content)
        {
            var postResult = await _client.PostAsync("https://localhost:5021/api/upload", content);
            var postContent = await postResult.Content.ReadAsStringAsync();
            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }
            else
            {
                var imgUrl = Path.Combine("https://localhost:5021/", postContent);
                return imgUrl;
            }
        }
    }
}
