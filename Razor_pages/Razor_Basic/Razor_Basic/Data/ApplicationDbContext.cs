using Microsoft.EntityFrameworkCore;
using Razor_Basic.Models;

namespace Razor_Basic.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}
