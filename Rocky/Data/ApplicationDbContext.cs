using Microsoft.EntityFrameworkCore;
using Rocky.Models;

namespace Rocky.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rocky.Models.ApplicationType> ApplicationType { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
