namespace DotNetFlixTerminal.Domain
{
    internal class Item
    {
        private string Title;
        private string Address;//not needed in terminal format

        public Item(string Title, string Address)
        {
            this.Title = Title;
            this.Address = Address;
        }

        public void View()
        {
            Console.WriteLine(Title + '\n' + Address+'\n');
        }

        public void Download()
        {
            //call FileDataAccess()
        }

        public void Print()
        {
            Console.WriteLine(Title + '\n' + Address + '\n');
        }


    }
}
