using Microsoft.EntityFrameworkCore;

namespace ProfileFinder.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<SearchedProfiles> SearchedProfiles { get; set; }
    }
}
