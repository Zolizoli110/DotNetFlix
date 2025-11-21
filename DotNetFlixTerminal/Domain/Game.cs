namespace DotNetFlixTerminal.Domain
{
  public class Game

    {
      public string Title  {get;set;}="";
      public string Publisher {get;set;}="";
      public string Genres {get;set;}="";
      public int ReleaseYear {get;set;}
      public float Version {get;set;}
      public string SupportedPlatforms {get;set;}="";
      

      
      public void Play(){
        Console.WriteLine("You are now playing this game:" +Title);
      }

      public void Download(){
        Console.WriteLine("You are now dowloading this game:" +Title);
      }
    }
}
