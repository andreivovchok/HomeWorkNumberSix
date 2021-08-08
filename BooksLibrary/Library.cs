using System;

namespace BooksLibrary
{
    public class Library
    {
        Book[] _books;

        public Library(Book[] books)
        {
            _books = books;
        }

        public Book[] Books
        {
            get { return _books; }
        }

        public Book GetBookByIndex(int index)
        {
            return _books[index];
        }

        public Book GetBookByTitle(string title)
        {
            foreach(Book book in _books)
            {
                if (title == book.Title)
                {
                    return book;
                }
            }
            return null;
        }
    }
}
