using System.ComponentModel.DataAnnotations;

namespace MyLibrary.Models
{
    public class Author
    {
        [Key]
        private int authorID; // Primary Key
        private string authorName = "n/a";
        public List<Book> Books { get; set; } = new List<Book>(); // Navigation property


        // Accessors and Mutators
        public int AuthorID
        {
            get { return this.authorID; }
            set { this.authorID = value; }
        }
        public string AuthorName
        {
            get { return this.authorName; }
            set { this.authorName = value; }
        }

        // Constructor
        public Author( string anAuthorName)
        {
            this.AuthorName = anAuthorName;
            Books = new List<Book>(); // Initialize List in Constructor

        }
        public Author(): this("n/a")
        {
            // Empty
        }

        // Tostring()
        public override string ToString()
        {
            string msg =
                $"""
                Author ID: {this.AuthorID}
                Author Name: {this.AuthorName}
                Books Written: {this.Books.Count}
                """;
            return msg;
        }
    }
}
