using Microsoft.EntityFrameworkCore;
using MySqlApi.Models;

namespace MySqlApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Map the PasswordHash property to the Passwrd column
            modelBuilder.Entity<User>()
                .Property(u => u.PasswordHash)
                .HasColumnName("Passwrd");
        }
    }
}