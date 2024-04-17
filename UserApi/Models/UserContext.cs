using Microsoft.EntityFrameworkCore;

namespace UserApi.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Tom Baguley",
                    Email = "tom.baguley@barclays.com",
                    IsAdmin = true,
                    Password = "tompass",
                },
                new User
                {
                    Id = 2,
                    Name = "Joe Bloggs",
                    Email = "joe.bloggs@barclays.com",
                    IsAdmin = false,
                    Password = "joe123"
                },
                new User
                {
                    Id = 3, 
                    Name = "Jane Smith", 
                    Email = "jane.smith",
                    IsAdmin = false,
                    Password = "js!?"
                }
                );
        }


    }
}
