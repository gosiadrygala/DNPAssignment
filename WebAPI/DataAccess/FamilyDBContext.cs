
using Microsoft.EntityFrameworkCore;
using Models;

namespace WebAPI.DataAccess
{
    public class FamilyDBContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Adult> Adults { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = FamilyDBAssignment.db");
        }

    }
}