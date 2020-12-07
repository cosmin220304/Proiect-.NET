using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Stalker.Controllers
{
    [Route("stalker")]
    [ApiController]
    public class TweetStalker : ControllerBase
    {
        static readonly HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

        [HttpGet("friends/{username}")]
        public async Task<string> GetFriendsAsync(string username)
        {
            string url = $"https://api.twitter.com/1.1/friends/list.json?screen_name={username}";
         
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();


            return $"https://api.twitter.com/1.1/friends/list.json?screen_name={username}";
        }
    }
}
