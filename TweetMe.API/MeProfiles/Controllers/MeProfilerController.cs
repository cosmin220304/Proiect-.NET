using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MeProfiler.ViewModels;
using System.Net;
using Newtonsoft.Json;
using System.Linq;

namespace MeProfiles.Controllers
{
    [Route("meprofiler")]
    [ApiController]
    public class MeProfilerController : ControllerBase
    {
        [HttpGet("/user")]
        public MeProfilerViewModel GetUserAsync(string username, int count)
        {
            var userUrl = $@"https://localhost:44316/stalker/users?username={username}";
            var tweetsUrl = $@"https://localhost:44316/stalker/tweets?username={username}&count={count}";

            using(var json = new WebClient())
            {
                var userJsonString = json.DownloadString(userUrl);
                var userProfiler = JsonConvert.DeserializeObject<MeProfilerViewModel>(userJsonString);

                var tweetsJsonString = json.DownloadString(tweetsUrl);
                userProfiler.Tweets = JsonConvert.DeserializeObject<IList<TweetViewModel>>(tweetsJsonString);

                for (var i = 0; i < userProfiler.Tweets.Count; i++)
                {
                    var tweetMessage = userProfiler.Tweets[i].Text;
                    var tweetRecoUrl = $@"https://localhost:44355/tweet-reco?SentimentText={tweetMessage}";
                    var tweetSentiment = int.Parse(json.DownloadString(tweetRecoUrl));
                    userProfiler.Tweets[i].Sentiment = tweetSentiment;
                }

                return userProfiler;
            }
        }
    }
}
