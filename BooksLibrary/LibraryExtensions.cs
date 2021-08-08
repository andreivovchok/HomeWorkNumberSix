using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLibrary
{
    public static class LibraryExtensions
    {
        public static Book GetLargestBook(this Library library)
        {
            Book largestBook = library.Books[0];
            for(int i = 1; i < library.Books.Length; i++)
            {
                if(largestBook.PagesCount < library.Books[i].PagesCount)
                {
                    largestBook = library.Books[i];
                }
            }
            return largestBook;   
        }
    }
}
