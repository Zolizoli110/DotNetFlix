namespace DotNetFlixTerminal.Domain
{
    internal class Image

    {
      public string Title  {get;set;}="";
      public string FileFormat {get;set;}="";
      public int FileSize {get;set;}
      public string DateTaken {get;set;}="";
      public int Resolution {get;set;}

      
      public void Display(){
        Console.WriteLine("You are now displaying this picture:" +Title);
      }

      public void Download(){
        Console.WriteLine("You are now dowloading this picture:" +Title);
      }
    }
}
