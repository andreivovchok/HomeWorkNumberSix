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

        public string Title
        {
            get { return _title; }
        }
        public string NameOfTheLibrary
        {
            get { return _nameOfTheLibrary; }
        }
        public int PagesCount
        {
            get { return _pagesCount; }
        }

    }
}
