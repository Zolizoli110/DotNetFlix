namespace DotNetFlixTerminal.Domain
{
    internal class Song

    {
      public string Title  {get;set;}="";
      public string Composer {get;set;}="";
      public string genres {get;set;}="";
      public string FileTypr {get;set;}="";
      public string language {get;set;}="";
      public int duration {get;set;}

      
      public void Play(){
        Console.WriteLine("You are now listening to this song:" +Title);
      }

      public void Download(){
        Console.WriteLine("You are now dowloading this song:" +Title);
      }
    }
}
