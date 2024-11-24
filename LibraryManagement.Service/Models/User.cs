using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Models
{
    public class User
    {

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserIdentificationNumber { get; set; }
        public string UserEmail { get; set; }
        public int UserHasRentedBook { get; set; }

    }
}
