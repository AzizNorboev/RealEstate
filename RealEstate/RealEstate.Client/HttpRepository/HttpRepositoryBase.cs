using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RealEstate.Client.HttpRepository
{
    public abstract class HttpRepositoryBase
    {
        protected HttpClient _client { get; set; }


        public HttpRepositoryBase(HttpClient client)
        {
            _client = client;
        }
    }
}
