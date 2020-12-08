using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Stalker.Controllers
{
    [Route("stalker")]
    [ApiController]
    public class TweetStalker : ControllerBase
    {
        static readonly HttpClient client = new HttpClient();
        string bearerToken = "AAAAAAAAAAAAAAAAAAAAALeKKQEAAAAAe9Q1UWlIkrRmnn6mDXYr7ReIqKM%3D2NVErtZ8HwZewlyejIZltJAL7ghbQ1SalgGWi0Nd8hZxqS5NHB";

        [HttpGet("friends/{username}")]
        public async Task<string> GetFriendsAsync(string username)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            string url = $"https://api.twitter.com/1.1/friends/list.json?screen_name={username}";
         
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();


            return responseBody;
        }
    }
}
