namespace DotNetFlixTerminal.Domain
{
    public class EBook
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Language { get; set; } = "";
        public string ISBN { get; set; } = "";
        public string Address { get; set; } = "";
        public int NumberOfPages { get; set; }
        public int PublicationYear { get; set; }
        

    }
}
