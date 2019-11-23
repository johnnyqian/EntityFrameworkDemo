using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo
{
    public class EFCoreDemoContext : DbContext
    {
        public EFCoreDemoContext() { }

        public DbSet<Student> Student { get; set; }

        public DbSet<Course> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\.;Database=EFCoreDemo;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
