﻿using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Stalker.Views;
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

        [HttpGet("users/{id}")]
        public async Task<UserViewModel> GetUserByIdAsync(int id)
        {
            var client = _twitterConnection.GetTwitterClient();

            string url = $"1.1/users/show.json?user_id={id}&include_user_entities=false";

            HttpResponseMessage response = await client.GetAsync(url);
            var responseBody = await response.Content.ReadAsStringAsync();
            UserViewModel user = JsonConvert.DeserializeObject<UserViewModel>(responseBody);

            return user;
        }


        [HttpGet("users")]
        public async Task<UserViewModel> GetUserByUsernameAsync([FromQuery] string username)
        {
            var client = _twitterConnection.GetTwitterClient();

            string url = $"1.1/users/show.json?screen_name={username}&include_user_entities=false";

            HttpResponseMessage response = await client.GetAsync(url);
            var responseBody = await response.Content.ReadAsStringAsync();
            UserViewModel user = JsonConvert.DeserializeObject<UserViewModel>(responseBody);

            return user;
        }

        [HttpGet("tweets")]
        public async Task<List<TweetViewModel>> GetTweetsOfUser([FromQuery] string username, [FromQuery] int count)
        {
            var client = _twitterConnection.GetTwitterClient();

            string url = $"1.1/statuses/user_timeline.json?screen_name={username}&count={count}";

            HttpResponseMessage response = await client.GetAsync(url);
            var responseBody = await response.Content.ReadAsStringAsync();
            List<TweetViewModel> tweets = JsonConvert.DeserializeObject<List<TweetViewModel>>(responseBody);

            return tweets;
        }
    }
}
