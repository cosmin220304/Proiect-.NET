using Microsoft.EntityFrameworkCore;

namespace TweetFinder.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<SearchedTweets> SearchedTweets { get; set; }
    }
}
