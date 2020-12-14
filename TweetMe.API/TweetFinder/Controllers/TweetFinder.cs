using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TweetFinder.Entities;

namespace TweetFinder.Controllers
{
    [Route("tweetfinder")]
    [ApiController]
    public class TweetFinder : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TweetFinder(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IEnumerable<Tweet> Count(int id)
        {
            var tweet = _context.Set<Tweet>().AsEnumerable<Tweet>();
            return tweet;
        }


    }
}
