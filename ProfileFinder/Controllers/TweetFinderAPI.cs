using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TweetFinder.Data;

namespace TweetFinder.Controllers
{
    [Route("tweetfinder/")]
    [ApiController]
    public class TweetFinderAPI : ControllerBase
    {
        public DataContext _context { get; set; }
        public TweetFinderAPI(DataContext context)
        {
            _context = context;
        }
        [HttpPatch("{twitter_id}")]
        public SearchedTweets UpdateSearchedTimes(int twitter_id)
        {
            var searchedTweet = _context.SearchedTweets.Select(tweet => tweet).Where(tweet=> tweet.TwitterId == twitter_id).FirstOrDefault();
            
            if(searchedTweet != null)
            {
                int nrOfSearched = searchedTweet.Searched;

                searchedTweet.Update(nrOfSearched + 1);
            }
            else
            {
                int nrOfSearched = 1;
                searchedTweet = new SearchedTweets()
                {
                    Searched = nrOfSearched,
                    TwitterId = twitter_id
                };

                _context.SearchedTweets.Add(searchedTweet);
                _context.SaveChanges();
            }

            return searchedTweet;
        }
    }
}
