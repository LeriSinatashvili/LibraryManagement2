using LibraryManagement.Service.Commands;
using LibraryManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services
{
    public class RentBookService
    {

        private readonly IRentBookRepository _rentBookRepository;

        public RentBookService(IRentBookRepository rentBookRepository)
        {

            _rentBookRepository = rentBookRepository;

        }

        public void ExecuteRentBookRenting(RentBookCommand command)
        {

            command.ValidateRentBook();


            var rentBookQuantity = _rentBookRepository.CheckBookQuantity(command.RentBookTitle);
            if(rentBookQuantity < 1)
            {
                throw new Exception();
            }

            var userHasRentedBooks = _rentBookRepository.CheckUserRentedBooksQuantity(command.RentUserIdentificationNumber);
            if(userHasRentedBooks >= 5)
            {
                throw new Exception();
            }

            var registerRenting = new RentBook();

            registerRenting.RentUserIdentificationNumber = command.RentUserIdentificationNumber;
            registerRenting.RentBookTitle = command.RentBookTitle;
            registerRenting.RentBookRented = 1;
            registerRenting.RentBookRentingDate = command.RentBookRentingDate;
            registerRenting.RentBookReturningDate = command.RentBookReturningDate;

            _rentBookRepository.RegisterRentBook(registerRenting);

        }

        public void ExecuteRentBookReturning(RentReturnBookCommand command)
        {

            command.ValidateRentReturnBook();

            int rentId = _rentBookRepository.GetRentId(command.RentUserIdentificationNumber, command.RentBookTitle);

            var registerReturning = new RentBook();

            registerReturning.RentBookId = rentId;
            registerReturning.RentBookRentingDate = command.RentBookReturningDate;

            _rentBookRepository.ReturnRentBook(registerReturning);

        }

    }
}
