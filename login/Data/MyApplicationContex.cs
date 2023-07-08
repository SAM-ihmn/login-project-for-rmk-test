using login.Models;
using Microsoft.EntityFrameworkCore;

namespace login.Data
{

    public class MyApplicationContex : DbContext
    {
        public MyApplicationContex(DbContextOptions<MyApplicationContex> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Rule> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rule>().HasData(
                new Rule { RuleId = 1, RuleTitle = "role_admin" },
                new Rule { RuleId = 2, RuleTitle = "role_user" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "admin", Password = "admin_password", RuleId = 1 },
                new User { UserId = 2, UserName = "user", Password = "user_password", RuleId = 2 }
            );
        }
    }
}

