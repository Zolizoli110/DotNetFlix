namespace DotNetFlixTerminal.Domain
{
    internal class VideoGame

    {
      public string Title  {get;set;}="";
      public string publisher {get;set;}="";
      public string genres {get;set;}="";
      public int releaseYear {get;set;}
      public float version {get;set;}
      public string supportedPlatforms {get;set;}="";
      

      
      public void Play(){
        Console.WriteLine("You are now playing this game:" +Title);
      }

      public void Download(){
        Console.WriteLine("You are now dowloading this game:" +Title);
      }
    }
}
