using LibraryManagement.Service.Commands;
using LibraryManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services
{
    public class BookService
    {

        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void ExecuteRegisterBook(RegisterBookCommand command)
        {

            command.ValidateBook();


            bool bookAutorExists = _bookRepository.BookAutorExists(command.BookAutor);
            if (!bookAutorExists)
            {
                throw new Exception();
            }


            bool bookTitleExists = _bookRepository.BookTitleExists(command.BookTitle);
            if (bookTitleExists)
            {
                throw new Exception();
            }



            var book = new Book();

            book.BookTitle = command.BookTitle;
            book.BookPublicationDate = command.BookPublicationDate;
            book.BookAutor = command.BookAutor;
            book.BookPagesNumber = command.BookPagesNumber;
            book.BookDescription = command.BookDescription;
            book.BookQuantity = command.BookQuantity;

            _bookRepository.RegisterBook(book);

        }

        public void ExecuteEditBook(EditBookCommand command)
        {

            command.ValidateBook();

            bool bookTitleExists = _bookRepository.BookTitleExists(command.BookTitle);
            if (!bookTitleExists)
            {
                throw new Exception();
            }

            int bookId = _bookRepository.GetBookId(command.BookTitle);

            var newBook = new Book();

            newBook.BookId = bookId;
            newBook.BookTitle = command.BookTitle;
            newBook.BookPublicationDate = command.BookPublicationDate;
            newBook.BookAutor = command.BookAutor;
            newBook.BookPagesNumber = command.BookPagesNumber;
            newBook.BookDescription = command.BookDescription;

            _bookRepository.RegisterBook(newBook);

        }

        public void ExecuteDeleteBook(DeleteBookCommand command)
        {

            command.ValidateBookDelete();

            bool bookTitleExists = _bookRepository.BookTitleExists(command.BookTitle);
            if (!bookTitleExists)
            {
                throw new Exception();
            }


            var deleteBook = new Book();

            deleteBook.BookTitle = command.BookTitle;

            _bookRepository.DeleteBook(deleteBook);

        }

    }
}
