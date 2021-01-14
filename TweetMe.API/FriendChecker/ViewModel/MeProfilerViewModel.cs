using System.Collections.Generic;

namespace FriendChecker.ViewModel
{
    public class MeProfilerViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string ImageUrl { get; set; }

        public IList<TweetViewModel> Tweets { get; set; }
    }
}
