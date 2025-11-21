using DotNetFlixTerminal.Data;

namespace DotNetFlixTerminal.Domain
{
    public class Movies
    {
        private IDataAccess _dataAccess;
        private List<Movie> MovieLibrary;

        public Movies(IDataAccess dataAccess)//idata
        {
            _dataAccess = dataAccess;
            MovieLibrary = _dataAccess.LoadMovies();
        }

        public string AddMovie(string Title, string director, string genres, int releaseYear, string language, int duration)
        {
            if (MovieLibrary.Any(b => b.Title == Title))
                return "Movie exists.";

            Movie movie = new Movie
            {
                Title = Title,
                Director = director,
                Genres = genres,
                ReleaseYear = releaseYear,
                Language = language,
                Duration = duration,
            };

            MovieLibrary.Add(movie);
            _dataAccess.SaveMovies(MovieLibrary);
            return "Movie added.\n";
        }

        public List<Movie> GetMovies()
        {
            return new List<Movie>(MovieLibrary);
        }
        public Movie FindMovie(string title)
        {
            foreach (Movie b in MovieLibrary)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return b;
            }
            return null;
        }

        public bool DeleteBook(string title)
        {
            Movie movie = FindMovie(title);
            if (movie == null) return false;

            MovieLibrary.Remove(movie);
            _dataAccess.SaveMovies(MovieLibrary);
            return true;
        }

        public string ViewMovie(string title)
        {
            foreach (Movie b in MovieLibrary)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return "Title: " + b.Title + " written by " + b.Director + " in " + b.Language + " with  length of : " + b.Duration; //+ ".; It has " + b.NumberOfPages + " pages and was published in" + b.PublicationYear + ".";
            }
            return "Movie does not exist";
        }

        public string ReadMovie(string title)
        {
            foreach (Movie b in MovieLibrary)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return "here you would open the mp4 file of the Movie";
            }
            return "Movie does not exist";
        }


    }
}
