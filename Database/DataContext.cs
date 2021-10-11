using asp.net_core_demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace asp.net_core_demo.Database
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
          : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
