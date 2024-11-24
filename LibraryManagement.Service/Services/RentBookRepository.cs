using LibraryManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services
{
    public class RentBookRepository : IRentBookRepository
    {

        public void RegisterRentBook(RentBook rentBook)
        {

            Console.WriteLine(rentBook.RentUserIdentificationNumber);
            Console.WriteLine(rentBook.RentBookTitle);
            Console.WriteLine(rentBook.RentBookRented);
            Console.WriteLine(rentBook.RentBookRentingDate);
            Console.WriteLine(rentBook.RentBookReturningDate);

        }

        public int CheckBookQuantity(string bookTitle)
        {

            return 1;

        }

        public int CheckUserRentedBooksQuantity(string userIdentificationNumber)
        {
            return 2;
        }

        public void ReturnRentBook(RentBook rentBook)
        {

            Console.WriteLine(rentBook.RentBookId);
            Console.WriteLine(rentBook.RentBookRentingDate);

        }


        public int GetRentId(string userIdentificationNumber, string bookTitle)
        {

            return 10;

        }

    }
}
