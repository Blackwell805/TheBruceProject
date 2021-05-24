using Microsoft.EntityFrameworkCore;

namespace RememberBruce.Models
{
    public class BruceContext : DbContext
    {
        public BruceContext(DbContextOptions options) : base(options) { }

        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<User> Users { get; set; }

    }
}