using System.Reflection;
using AS_biblioteca.Data.Types;
using AS_biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AS_biblioteca.Data.Context
{
    public class DataContext : DbContext
    {
        protected string DbPath{ get; }
        public DataContext(){
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "agenciaBancria.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={DbPath}");

        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Library { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());    
        }
    }
}