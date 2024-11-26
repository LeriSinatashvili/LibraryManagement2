using LibraryManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services.Abstractions
{
    public interface IBookRepository
    {

        void RegisterBook(Book book);

        bool BookAutorExists(string bookAutor);

        bool BookTitleExists(string bookTitle);

        int GetBookId(string bookTitle);

        void DeleteBook(Book book);

    }
}
