using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MeProfiler.ViewModels;
using System.Net;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace MeProfiles.Controllers
{
    [Route("meprofiler")]
    [ApiController]
    public class MeProfilerController : ControllerBase
    {
        [HttpGet("profileByUsername")]
        public MeProfilerViewModel ProfileUserByUsername(string username, int count)
        {
            var userUrl = $@"https://localhost:44316/stalker/users?username={username}";
            var tweetsUrl = $@"https://localhost:44316/stalker/tweets?username={username}&count={count}";

            var json = new WebClient();
            var userJsonString = json.DownloadString(userUrl);
            var userProfiler = JsonConvert.DeserializeObject<MeProfilerViewModel>(userJsonString);

            try
            {
                var tweetsJsonString = json.DownloadString(tweetsUrl);
                userProfiler.Tweets = JsonConvert.DeserializeObject<IList<TweetViewModel>>(tweetsJsonString);

                for (var i = 0; i < userProfiler.Tweets.Count; i++)
                {
                    var tweetMessage = userProfiler.Tweets[i].Text;
                    var tweetRecoUrl = $@"https://localhost:44355/tweet-reco?SentimentText={tweetMessage}";
                    var tweetSentiment = int.Parse(json.DownloadString(tweetRecoUrl));
                    userProfiler.Tweets[i].Sentiment = tweetSentiment;
                }
            }
            catch (Exception)
            {
                userProfiler.Tweets = null;
            }

            json.Dispose();
            return userProfiler;
        }

        [HttpGet("profileById")]
        public MeProfilerViewModel ProfileUserById(int id, int count)
        {
            var userUrl = $@"https://localhost:44316/stalker/users/{id}";

            var json = new WebClient();
            var userJsonString = json.DownloadString(userUrl);
            var userProfiler = JsonConvert.DeserializeObject<MeProfilerViewModel>(userJsonString);

            try
            {
                var tweetsUrl = $@"https://localhost:44316/stalker/tweets?username={userProfiler.Username}&count={count}";
                var tweetsJsonString = json.DownloadString(tweetsUrl);
                userProfiler.Tweets = JsonConvert.DeserializeObject<IList<TweetViewModel>>(tweetsJsonString);

                for (var i = 0; i < userProfiler.Tweets.Count; i++)
                {
                    var tweetMessage = userProfiler.Tweets[i].Text;
                    var tweetRecoUrl = $@"https://localhost:44355/tweet-reco?SentimentText={tweetMessage}";
                    var tweetSentiment = int.Parse(json.DownloadString(tweetRecoUrl));
                    userProfiler.Tweets[i].Sentiment = tweetSentiment;
                }
            }
            catch (Exception)
            {
                userProfiler.Tweets = null;
            }

            json.Dispose();
            return userProfiler;
        }

    }
}