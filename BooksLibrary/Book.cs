namespace BooksLibrary
{
    public class Book
    {
        private string _title;
        private string _nameOfTheLibrary;
        private int _pagesCount;

        public Book(string title, string nameOfTheLibrary, int pagesCount)
        {
            _title = title;
            _nameOfTheLibrary = nameOfTheLibrary;
            _pagesCount = pagesCount;
        }

    }
}
