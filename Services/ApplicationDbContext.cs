using Microsoft.EntityFrameworkCore;
using TODO_app.Models;
namespace TODO_app.Services
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=sr0sql01;Database=KorData-DEV;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("vlad");
        }
    }
}