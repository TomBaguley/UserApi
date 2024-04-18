using Microsoft.EntityFrameworkCore;

namespace UserApi.Models
{
    public class JobContext :DbContext
    {

        public JobContext(DbContextOptions<JobContext> options) : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<Job> Tasks { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasData(
                new Job
                {
                    Id = 1,
                    Name = "Create classes",
                    StartDate = new DateTime(2024, 04, 10),
                    Deadline = new DateTime(2024, 05, 01),
                    Assignee = "Tom Baguley"

                },
                new Job
                {
                    Id = 2,
                    Name = "Decomission legacy apps",
                    StartDate = new DateTime(2024, 05, 01),
                    Deadline = new DateTime(2025, 05, 01),
                    Assignee = "Joe Bloggs"
                },
                new Job
                {
                    Id = 3,
                    Name = "Migrate to new LTS",
                    StartDate = new DateTime(2024, 03, 12),
                    Deadline = new DateTime(2024, 04, 15),
                    Assignee = "Jane Smith"
                }
                );
        }
    }
}
