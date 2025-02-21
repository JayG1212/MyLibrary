namespace MyShelves.Models
{
    public class Genre
    {
        private int genreID = -1;
        private string genreName = "n/a";

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
        public Genre() : this(-1, "n/a")
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
                """;
            return msg;
        }
    }
}
