namespace DotNetFlixTerminal.Domain
{
    public class Ebooks
    {
        private IDataAccess _dataAccess;
        private List<EBook> BookLibrary;

        public Ebooks(IDataAccess dataAccess)//idata
        {
            _dataAccess = dataAccess;
            BookLibrary = _dataAccess.LoadBooks();
        }

        public string AddBook(string Title,string Author, string Language, string ISBN, string Address, int NumberOfPages,int PublicationYear)
        {
            if (BookLibrary.Any(b => b.Title == Title))
                return "Book exists.";

            EBook ebook = new EBook
            {
                Title = Title,
                Author = Author,
                Language = Language,
                ISBN = ISBN,
                Address = Address,
                NumberOfPages = NumberOfPages,
                PublicationYear = PublicationYear
            };

            BookLibrary.Add(ebook);
            _dataAccess.SaveEBooks(BookLibrary);
            return "EBook added.\n";
        }

        public List<EBook> GetBooks()
        {
            return new List<EBook>(BookLibrary);
        }

        public EBook FindBook(string title)
        {
            foreach (EBook b in BookLibrary)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return b;
            }
            return null;
        }

        public bool DeleteBook(string title)
        {
            EBook book = FindBook(title);
            if (book == null) return false;

            BookLibrary.Remove(book);
            _dataAccess.SaveBooks(BookLibrary);
            return true;
        }

        public string ViewBook(string title)
        {
            foreach (EBook b in BookLibrary)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return "Title: " + b.Title + " written by" + b.Author + "";
            }
        }


    }
}
