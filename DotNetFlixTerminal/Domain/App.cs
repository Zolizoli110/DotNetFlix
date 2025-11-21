namespace DotNetFlixTerminal.Domain
{
    internal class App

    {
      public string Title  {get;set;}="";
      public string publisher {get;set;}="";
      public int releaseYear {get;set;}
      public float version {get;set;}
      public string supportedPlatforms {get;set;}="";
      

      
      public void Execute(){
        Console.WriteLine("You are now executing this app:" +Title);
      }

      public void Download(){
        Console.WriteLine("You are now dowloading this app:" +Title);
      }
    }
}
