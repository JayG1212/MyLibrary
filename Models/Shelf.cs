using System.ComponentModel.DataAnnotations;

namespace MyLibrary.Models
{
    public class Shelf
    {
        [Key]
        private int shelfID; // Primary Key
        private string shelfName = "n/a";
        public List<Book> Books { get; set; } = new List<Book>(); // Navigation property

        // Accessors and Mutators
        public int ShelfID
        {
            get { return this.shelfID; }
            set { this.shelfID = value; }
        }

        public string ShelfName
        {
            get { return this.shelfName; }
            set {this.shelfName = value; }
        }

        // Constructors

        public Shelf( string aShelfName)
        {
            this.ShelfName = aShelfName;
            Books = new List<Book>(); // Initializes list
        }
        
        public Shelf(): this("n/a")
        {
            // Empty
        }


        // ToString()

        public override string ToString()
        {
            string msg = "";
            msg += $"""
                Shelf ID {this.ShelfID}
                Shelf Name {this.ShelfName}
                Books on Shelf: {this.Books.Count}
                """;
            return msg;
        }
    }
}
