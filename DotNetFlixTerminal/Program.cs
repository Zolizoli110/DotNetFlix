using DotNetFlix.Data;
using DotNetFlix.Domain;
using DotNetFlix.Presentation;
class Program
{
    static void Main()
    {
        //FileDataAccess dataAccess = new FileDataAccess("books.json");
        //BookDatabase database = new BookDatabase(dataAccess);
        DotNetFlixUI ui = new DotNetFlixUI(database);
        ui.Run();
    }
}
