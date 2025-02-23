using MyLibrary.Models;

using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Shelf> Shelves { get; set; }

        // Table names
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Shelf>().ToTable("Shelf");
        }
    }


}
