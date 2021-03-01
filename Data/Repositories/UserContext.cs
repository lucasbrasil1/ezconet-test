using ezconet_test.Models;
using Microsoft.EntityFrameworkCore;

namespace ezconet_test.Data.Repositories
{
    public class UserContext : DbContext
    {

        public DbSet<Users> User { get; set; }
        public string connectionString = "server=localhost;database=ezconet;user=root;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.BirthDate).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Gender).IsRequired().HasMaxLength(1);
                entity.Property(e => e.Active).HasMaxLength(1);
            });             
        }
    }
}
