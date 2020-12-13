using Microsoft.Extensions.Configuration;
using Stalker.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Stalker.Services
{
    public class TwitterConnection : ITwitterConnection
    {
        private readonly IConfiguration _configuration;
        public TwitterConnection(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public HttpClient GetTwitterClient()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(_configuration.GetSection("Twitter")["BaseUrl"])
            };

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _configuration.GetSection("Twitter")["BearerToken"]);

            return client;
        }
    }
}
