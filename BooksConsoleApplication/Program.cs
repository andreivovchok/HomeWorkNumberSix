using System;
using BooksLibrary;

namespace BooksConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book("Война и мир", "Национальная", 1000),
                new Book("Горе от ума", "Национальная", 200),
                new Book("1984", "Национальная", 6000),
            };

            Library library = new Library(books);
            Book largestBook = library.GetLargestBook();
            Console.WriteLine($"Название книги - {largestBook.Title}");
            Console.WriteLine($"Название библиотеки - {largestBook.NameOfTheLibrary}");
            Console.WriteLine($"Количество страниц - {largestBook.PagesCount}");



            Console.WriteLine("Введите название книги!");
            string bookTitle = Console.ReadLine();
            Book book = library.GetBookByTitle(bookTitle);

            if (book == null)
            {
                Console.WriteLine("Нет такой книги!");
            }
            else
            {
                Console.WriteLine($"Название книги - {book.Title}");
                Console.WriteLine($"Название библиотеки - {book.NameOfTheLibrary}");
                Console.WriteLine($"Количество страниц - {book.PagesCount}");
            }



        }
    }
}
