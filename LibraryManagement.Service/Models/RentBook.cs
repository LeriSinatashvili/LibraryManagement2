using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Models
{
    public class RentBook
    {

        public int RentBookId { get; set; }
        public string RentUserIdentificationNumber { get; set; }
        public string RentBookTitle { get; set; }
        public int RentBookRented { get; set; }
        public DateTime? RentBookRentingDate { get; set; }
        public DateTime? RentBookReturningDate { get; set; }

    }
}
