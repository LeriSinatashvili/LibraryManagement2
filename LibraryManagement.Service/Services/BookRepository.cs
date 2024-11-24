using LibraryManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services
{
    public class BookRepository : IBookRepository
    {

        public void RegisterBook(Book book)
        {

            Console.WriteLine(book.BookTitle);
            Console.WriteLine(book.BookPublicationDate);
            Console.WriteLine(book.BookPagesNumber);
            Console.WriteLine(book.BookQuantity);
            Console.WriteLine(book.BookAutor);
            Console.WriteLine(book.BookDescription);

        }

        public bool BookAutorExists(string bookAutor)
        {
            return true;
        }

        public bool BookTitleExists(string bookTitle)
        {
            return true;
        }

        public int GetBookId(string bookTitle)
        {
            return 1;
        }

        public void DeleteBook(Book book)
        {

            Console.WriteLine(book.BookTitle);

        }

    }
}
