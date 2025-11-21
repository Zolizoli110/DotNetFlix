namespace DotNetFlixTerminal.Domain
{
    internal class Item
    {
        private string _title;
        private string _address;//not needed in terminal format

        public Item(string Title, string Address)
        {
            this._title = Title;
            this._address = Address;
        }

        public void View()
        {
            Console.WriteLine(_title + '\n' + _address+'\n');
        }

        public void Download()
        {
            //call FileDataAccess()
        }

        public void Print()
        {
            Console.WriteLine(_title + '\n' + _address + '\n');
        }


    }
}
