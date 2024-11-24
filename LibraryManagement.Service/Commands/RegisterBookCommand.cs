using LibraryManagement.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LibraryManagement.Service.Commands
{
    public class RegisterBookCommand
    {

        public string BookTitle { get; set; }
        public DateTime BookPublicationDate { get; set; }
        public string BookAutor { get; set; }
        public int BookPagesNumber { get; set; }
        public string BookDescription { get; set; }
        public int BookQuantity { get; set; }

        public void ValidateBook()
        {

            if(BookTitle.Length < 1 || BookTitle.Length > 250)
            {
                throw new Exception();
            }

            if (BookPublicationDate > DateTime.Now)
            {
                throw new Exception();
            }

            if (BookAutor.Length < 1 || BookAutor.Length > 100)
            {
                throw new Exception();
            }

            if(BookPagesNumber < 1)
            {
                throw new Exception();
            }

            if(BookDescription.Length < 1 || BookDescription.Length > 1000)
            {
                throw new Exception();
            }

            if(BookQuantity < 0)
            {
                throw new Exception();
            }

        }

    }

    public class EditBookCommand
    {

        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public DateTime BookPublicationDate { get; set; }
        public string BookAutor { get; set; }
        public int BookPagesNumber { get; set; }
        public string BookDescription { get; set; }

        public void ValidateBook()
        {

            if (BookTitle.Length < 1 || BookTitle.Length > 250)
            {
                throw new Exception();
            }

            if (BookPublicationDate > DateTime.Now)
            {
                throw new Exception();
            }

            if (BookAutor.Length < 1 || BookAutor.Length > 100)
            {
                throw new Exception();
            }

            if (BookPagesNumber < 1)
            {
                throw new Exception();
            }

            if (BookDescription.Length < 1 || BookDescription.Length > 1000)
            {
                throw new Exception();
            }

        }

    }

    public class DeleteBookCommand
    {
        public string BookTitle { get; set; }

        public void ValidateBookDelete()
        {

            if (BookTitle.Length < 1 || BookTitle.Length > 250)
            {
                throw new Exception();
            }

        }

    }


}
