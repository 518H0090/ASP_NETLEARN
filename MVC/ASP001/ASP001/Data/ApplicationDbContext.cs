using ASP001.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP001.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> categories { get; set; }
    }
}
