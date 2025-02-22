namespace MyLibrary.Models
{
    public class Genre
    {
        private int genreID = 0; // Primary Key
        private string genreName = "n/a";
        public List<Book> Books { get; set; } = new List<Book>(); // Navigation property

        // Accessors and Mutators
        public int GenreID
        {
            get { return this.genreID; }
            set { this.genreID = value; }
        }
        public string GenreName
        {
            get { return this.genreName; }
            set { this.genreName = value; }
        }

        // Constructor
        public Genre(int aGenreID, string aGenreName)
        {
            this.GenreID = aGenreID;
            this.GenreName = aGenreName;
        }
        public Genre() : this(0, "n/a")
        {
            // Empty
        }

        // Tostring()
        public override string ToString()
        {
            string msg =
                $"""
                Genre ID: {this.GenreID}
                Genre Name: {this.GenreName}
                Books in Genre: {this.Books.Count}
                """;
            return msg;
        }
    }
}
