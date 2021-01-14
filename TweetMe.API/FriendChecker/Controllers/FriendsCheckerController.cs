using FriendChecker.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace FriendChecker.Controllers
{
    [Route("friendChecker")]
    [ApiController]
    public class FriendsCheckerController : Controller
    {
        [HttpGet("getByUsername")]
        public FriendCheckerViewModel GetByUsername(string username, int tweetsPerUser)
        {
            var happyFriends = new List<FriendViewModel>();
            var sadFriends = new List<FriendViewModel>();

            using (var json = new WebClient())
            {
                var friendsUrl = $@"https://localhost:44303/stalker/friends/{username}";
                var friendsJsonString = json.DownloadString(friendsUrl);
                var friends = JsonConvert.DeserializeObject<IList<FriendViewModel>>(friendsJsonString);

                foreach(var friend in friends)
                {
                    var profilerUrl = @$"https://localhost:44303/meprofiler/profileByUsername?username={friend.Username}&count={tweetsPerUser}";
                    var profilerJsonString = json.DownloadString(profilerUrl);
                    var friendProfiler = JsonConvert.DeserializeObject<MeProfilerViewModel>(profilerJsonString);

                    if (friendProfiler.Tweets == null) continue;

                    var sentimentSum = 0;
                    foreach(var friendTweet in friendProfiler.Tweets)
                    {
                        sentimentSum += friendTweet.Sentiment;
                    }

                    friend.mood = (double)sentimentSum / 10;

                    if (friend.mood >= 0.5)
                    {
                        happyFriends.Add(friend);
                    }
                    else
                    {
                        sadFriends.Add(friend);
                    }
                }
            }

            var friendChecker = new FriendCheckerViewModel
            {
                HappyFriends = happyFriends,
                SadFriends = sadFriends
            };
            return friendChecker; 
        }
    }
}
