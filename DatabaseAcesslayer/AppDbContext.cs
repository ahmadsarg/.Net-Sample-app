using Microsoft.EntityFrameworkCore;
using SampleApp.Models;

namespace SampleApp.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}