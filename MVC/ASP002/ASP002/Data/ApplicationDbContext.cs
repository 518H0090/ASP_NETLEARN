using ASP002.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP002.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> categories { get; set; }
    }
}
