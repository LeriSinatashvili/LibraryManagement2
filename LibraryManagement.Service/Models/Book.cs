using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Models
{
    public class Book
    {

        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public DateTime BookPublicationDate { get; set; }
        public string BookAutor { get; set; }
        public int BookPagesNumber { get; set; }
        public string BookDescription { get; set; }
        public int BookQuantity { get; set; }

    }
}
