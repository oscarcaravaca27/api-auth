// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using AuthAPI.Models;

namespace AuthAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users{ get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
