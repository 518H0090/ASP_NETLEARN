using ASP_MVC_FULL.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_MVC_FULL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> categories { get; set; }
    }
}
