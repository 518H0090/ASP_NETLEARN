using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationship.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Character> characters { get; set; }
    }
}
