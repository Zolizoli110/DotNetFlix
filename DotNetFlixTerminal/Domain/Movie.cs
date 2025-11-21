namespace DotNetFlixTerminal.Domain
{
    internal class Movie

    {
      public string Title  {get;set;}="";
      public string director {get;set;}="";
      public string genres {get;set;}="";
      public int releaseYear {get;set;}
      public string language {get;set;}="";
      public int duration {get;set;}

      
      public void Watch(){
        Console.WriteLine("You are now watching this movie:" +Title);
      }

      public void Download(){
        Console.WriteLine("You are now dowloading this movie:" +Title);
      }
    }
}
