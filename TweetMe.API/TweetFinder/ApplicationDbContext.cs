using Microsoft.EntityFrameworkCore;
using TweetFinder.Entities;

namespace TweetFinder
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Tweet> tweet { get; set; }
    }
}
