namespace MyLibrary.Models
{
    public class Shelf
    {
        private int shelfID = -1;
        private string shelfName = "n/a";

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
        
        public Shelf(): this(-1, "n/a")
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
                """;
            return msg;
        }
    }
}
