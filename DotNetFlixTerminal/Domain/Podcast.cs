namespace DotNetFlixTerminal.Domain
{
    internal class Podcast

    {
      public string Title  {get;set;}="";
      public int ReleaseYear {get;set;}
      public string Host {get;set;}="";
      public string Guest {get;set;}="";
      public string language {get;set;}="";
      public int EpisodeNumber {get;set;}

      
      public void Listen(){
        Console.WriteLine("You are now listening to this podcast:" +Title);
      }

      public void Download(){
        Console.WriteLine("You are now dowloading this podcast:" +Title);
      }
    }
}
