namespace MyShelves.Models
{
    public class Author
    {
        private int authorID = -1;
        private string authorName = "n/a";

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
        public Author(int anAuthorID, string anAuthorName)
        {
            this.AuthorID = anAuthorID;
            this.AuthorName = anAuthorName;
        }
        public Author(): this(-1, "n/a")
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
                """;
            return msg;
        }
    }
}
