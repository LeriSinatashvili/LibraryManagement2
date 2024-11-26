using LibraryManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services.Abstractions
{
    public interface IRentBookRepository
    {

        void RegisterRentBook(RentBook rentBook);

        int CheckBookQuantity(string bookTitle);

        int CheckUserRentedBooksQuantity(string userIdentificationNumber);


        void ReturnRentBook(RentBook rentBook);

        int GetRentId(string userIdentificationNumber, string bookTitle);
    }
}
