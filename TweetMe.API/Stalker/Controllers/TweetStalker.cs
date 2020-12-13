using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Stalker.Views;
using Stalker.Services;
using Stalker.Interfaces;

namespace Stalker.Controllers
{
    [Route("stalker")]
    [ApiController]
    public class TweetStalker : ControllerBase
    {
        private readonly ITwitterConnection _twitterConnection;

        public TweetStalker(ITwitterConnection twitterConnection)
        {
            _twitterConnection = twitterConnection;
        }
        [HttpGet("friends/{username}")]
        public async Task<List<UserViewModel>> GetFriendsAsync(string username)
        {
            var client = _twitterConnection.GetTwitterClient();
           
            string url = $"1.1/friends/list.json?screen_name={username}&include_user_entities=false";
         
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            FriendListViewModel friends =  JsonConvert.DeserializeObject<FriendListViewModel>(responseBody);
          
            return friends.Users;
        }


    }
}
