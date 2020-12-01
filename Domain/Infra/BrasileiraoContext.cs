using Microsoft.EntityFrameworkCore;
using Domain.Users;

namespace Domain.Infra
{
    public class BrasileiraoContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<User> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;User Id=sa;PWD=P@SsW0rd;Initial Catalog=Brasileirao");
        }
    }
}