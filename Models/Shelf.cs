namespace MyShelves.Models
{
    public class Shelf
    {
        private int shelfID = -1;
        private int bookID = -1;

        // Accessors and Mutators
        public int ShelfID
        {
            get { return this.shelfID; }
            set { this.shelfID = value; }
        }

        public int BookID
        {
            get { return this.bookID; }
            set {this.bookID = value; }
        }

    }
}
