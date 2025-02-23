using MyLibrary.Models;
using System;
using System.Linq;
namespace MyLibrary.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            // Ensure related data (Authors, Genres, Shelves) exist first
            var author = new Author { AuthorName = "Herman Melville" };
            var genre = new Genre { GenreName = "Fiction" };
            var shelf = new Shelf { ShelfName = "Read" };
            
            // Add and save related data
            context.Authors.Add(author);
            context.Genres.Add(genre);
            context.Shelves.Add(shelf);
            context.SaveChanges(); // Save to generate IDs

            var books = new Book[]
            {
                new Book
                {
                    Title="Moby Dick", 
                    PublicationYear=1851, 
                    Pages=625,
                    Author = author, 
                    Genre = genre,    
                    Shelf = shelf 
                }

            };
            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();

        }
    }
}
