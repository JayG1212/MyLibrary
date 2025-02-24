using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models
{
    public class Book
    {
        // Varialbes
        [Key]
        private int bookID; // Primary Key
        private string title = "N/A";
        private int publicationYear = -1;
        private int pages = -1;

        // Foreign Keys
        public int AuthorID { get; set; }
        public int GenreID { get; set; }
        public int ShelfID { get; set; }

        // Navigation Properties (Relationships)
        [ForeignKey("AuthorID")]
        public Author Author { get; set; }

        [ForeignKey("GenreID")]
        public Genre Genre { get; set; }

        [ForeignKey("ShelfID")]
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
       /* public Book(string aTitle, int aPublicationYear, int somePages, int authorID, int genreID, int shelfID)
        {
            this.Title = aTitle;
            this.PublicationYear = aPublicationYear;
            this.Pages = somePages;
            this.AuthorID = authorID;
            this.GenreID = genreID;
            this.ShelfID = shelfID;

        }*/
        public Book() { }
       /* public Book() : this(0, "n/a", -1, -1, new Author(), new Genre(), new Shelf())
        {
            // Empty
        }*/

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
