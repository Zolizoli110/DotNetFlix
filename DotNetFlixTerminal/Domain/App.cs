namespace DotNetFlixTerminal.Domain
{
  public class App

    {
      public string Title  {get;set;}="";
      public string Publisher {get;set;}="";
      public int ReleaseYear {get;set;}
      public float Version {get;set;}
      public string SupportedPlatforms {get;set;}="";
      

      
      public void Execute(){
        Console.WriteLine("You are now executing this app:" +Title);
      }

      public void Download(){
        Console.WriteLine("You are now dowloading this app:" +Title);
      }
    }
}
