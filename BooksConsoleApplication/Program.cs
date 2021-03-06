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
                new Book("Горе от ума", "Национальная", 2000),
                new Book("1984", "Национальная", 600),
            };

            Library library = new Library(books);
            Book largestBook = library.GetLargestBook();
            Console.WriteLine($"Название книги - {largestBook.Title}");
            Console.WriteLine($"Название библиотеки - {largestBook.NameOfTheLibrary}");
            Console.WriteLine($"Количество страниц - {largestBook.PagesCount}");

            Console.WriteLine();

            Book indexBook = library.GetBookByIndex(0);
            Console.WriteLine($"Название книги - {indexBook.Title}");
            Console.WriteLine($"Название библиотеки - {indexBook.NameOfTheLibrary}");
            Console.WriteLine($"Количество страниц - {indexBook.PagesCount}");

            Console.WriteLine();

            Console.WriteLine("Введите название книги!");
            while (true)
            {
                string bookTitle = Console.ReadLine();
                Book book = library.GetBookByTitle(bookTitle);
                if (book == null)
                {
                    Console.WriteLine("Нет такой книги, попробуйте еще раз!");
                }
                else
                {
                    Console.WriteLine($"Название книги - {book.Title}");
                    Console.WriteLine($"Название библиотеки - {book.NameOfTheLibrary}");
                    Console.WriteLine($"Количество страниц - {book.PagesCount}");
                    break;
                }
            }
        }
    }
}
