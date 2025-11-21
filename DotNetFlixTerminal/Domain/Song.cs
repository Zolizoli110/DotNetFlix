namespace DotNetFlixTerminal.Domain
{
  public class Song

    {
      public string Title  {get;set;}="";
      public string Composer {get;set;}="";
      public string Genres {get;set;}="";
      public string FileType {get;set;}="";
      public string Language {get;set;}="";
      public int Duration {get;set;}

      
      public void Play(){
        Console.WriteLine("You are now listening to this song:" +Title);
      }

      public void Download(){
        Console.WriteLine("You are now dowloading this song:" +Title);
      }
    }
}
