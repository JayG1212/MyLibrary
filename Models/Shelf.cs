namespace MyLibrary.Models
{
    public class Shelf
    {
        private int shelfID = 0; // Primary Key
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

        public Shelf(int aShelfID, string aShelfName)
        {
            this.ShelfID = aShelfID;
            this.ShelfName = aShelfName;
        }
        
        public Shelf(): this(0, "n/a")
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
