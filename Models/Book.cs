namespace MyLibrary.Models
{
    public class Book
    {
        // Varialbes

        private int bookID = -1;
        private string title = "N/A";
        private int authorID = -1;
        private int publicationYear = -1;
        private int pages = -1;
        private int genreID = -1;

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
        public int AuthorID
        {
            get { return this.authorID; }
            set { this.authorID = value; }
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
        public int GenreID
        {
            get { return this.genreID; }
            set { this.genreID = value; }
        }

        // Constructor
        public Book(int aBookID, string aTitle, int anAuthorID, int aPublicationYear, int somePages, int aGenreID)
        {
            this.BookID = aBookID;
            this.Title = aTitle;
            this.AuthorID = anAuthorID;
            this.PublicationYear = aPublicationYear;
            this.Pages = somePages;
            this.GenreID = aGenreID;
        }

        public Book() : this(-1, "n/a", -1, -1, -1, -1)
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
                AuthorID: {this.AuthorID}
                PublicationYear: {this.PublicationYear}
                Pages: {this.Pages}
                GenreID: {this.GenreID}
                """;

            return msg;
        }


    }
}
