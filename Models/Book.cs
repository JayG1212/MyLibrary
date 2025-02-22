using System;

namespace MyLibrary.Models
{
    public class Book
    {
        // Varialbes

        private int bookID = 0; // Primary Key
        private string title = "N/A";
        private int publicationYear = -1;
        private int pages = -1;

        //Navigation Properties (Foreign keys)
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public Shelf Shelf { get; set; }



        // Accessors and Mutators

        public int BookID
        {
            get { return this.bookID; }
            set { this.bookID = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
    
        public int PublicationYear
        {
            get { return this.publicationYear; }
            set { this.publicationYear = value; }
        }
        public int Pages
        {
            get { return this.pages; }
            set { this.pages = value; }
        }
    

        // Constructor
        public Book(int aBookID, string aTitle, int aPublicationYear, int somePages,Author anAuthor, Genre aGenre, Shelf aShelf)
        {
            this.BookID = aBookID;
            this.Title = aTitle;
            this.PublicationYear = aPublicationYear;
            this.Pages = somePages;
            this.Author = anAuthor ?? new Author(); 
            this.Genre = aGenre ?? new Genre(); 
            this.Shelf = aShelf ?? new Shelf(); 

        }

        public Book() : this(0, "n/a", -1, -1, new Author(), new Genre(), new Shelf())
        {
            // Empty
        }

        // ToString()
        public override string ToString()
        {
            string msg = "";

            msg += $"""

                BookID: {this.BookID}
                Title: {this.Title}
                Author: {this.Author.AuthorName ?? "Unknown"}
                PublicationYear: {this.PublicationYear}
                Pages: {this.Pages}
                Genre: {this.Genre.GenreName ?? "Unknown"}
                Shelf: {this.Shelf.ShelfName ?? "Unknown"}
                """;

            return msg;
        }


    }
}
