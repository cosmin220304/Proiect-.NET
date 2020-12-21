using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetFinder.Data
{
    public class SearchedTweets
    {
        public SearchedTweets()
        {

        }
        public int ID { get; set; }
        public long TwitterId { get; set; }
        public int Searched { get; set; }

        public void Update(int searched)
        {
            Searched = searched;
        }

    }
}
