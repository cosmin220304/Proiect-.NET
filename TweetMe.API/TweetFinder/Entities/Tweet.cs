using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetFinder.Entities
{
    public class Tweet
    {
        public int Id { get; set; }
        public long TwitterId { get; set; }
        public int Searched { get; set; }
    }
}
