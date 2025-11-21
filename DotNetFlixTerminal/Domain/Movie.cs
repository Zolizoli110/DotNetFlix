namespace DotNetFlixTerminal.Domain
{
    public class Movie
    {
      public string Title  {get;set;}="";
      public string Director {get;set;}="";
      public string Genres {get;set;}="";
      public int ReleaseYear {get;set;}
      public string Language {get;set;}="";
      public int Duration {get;set;}

      
      public void Watch(){
        Console.WriteLine("You are now watching this movie:" +Title);
      }

      public void Download(){
        Console.WriteLine("You are now dowloading this movie:" +Title);
      }
    }
}
