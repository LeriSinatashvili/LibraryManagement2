using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Commands
{
    public class RentBookCommand
    {

        public string RentUserIdentificationNumber { get; set; }
        public string RentBookTitle { get; set; }
        public int RentBookRented { get; set; }
        public DateTime RentBookRentingDate { get; set; }
        public DateTime? RentBookReturningDate { get; set; }

        public void ValidateRentBook()
        {

            foreach (char character in RentUserIdentificationNumber)
            {
                if (character < '0' || character > '9')
                    throw new Exception();
            }

            if (RentUserIdentificationNumber.Length != 11)
            {
                throw new Exception();
            }

            if (RentBookTitle.Length < 1 || RentBookTitle.Length > 250)
            {
                throw new Exception();
            }

        }

    }

    public class RentReturnBookCommand
    {
        public string RentUserIdentificationNumber { get; set; }
        public string RentBookTitle { get; set; }
        public int RentBookRented { get; set; }
        public DateTime RentBookRentingDate { get; set; }
        public DateTime? RentBookReturningDate { get; set; }

        public void ValidateRentReturnBook()
        {

            foreach (char character in RentUserIdentificationNumber)
            {
                if (character < '0' || character > '9')
                    throw new Exception();
            }

            if (RentUserIdentificationNumber.Length != 11)
            {
                throw new Exception();
            }

            if (RentBookTitle.Length < 1 || RentBookTitle.Length > 250)
            {
                throw new Exception();
            }

        }
    }

}
