using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Data
{
    public class AllUpDbContext : DbContext
    {
        public DbSet <Settings> Settings { get; set; }
        public AllUpDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
