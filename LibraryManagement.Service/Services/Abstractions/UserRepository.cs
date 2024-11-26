using LibraryManagement.Service.Commands;
using LibraryManagement.Service.Context;
using LibraryManagement.Service.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services.Abstractions
{


    public class UserRepository : IUserRepository
    {

        public void RegisterUser(User user)
        {


            Console.WriteLine(user.UserName);
            Console.WriteLine(user.UserEmail);


        }

        public bool UserIdentificationNumberExists(string userIdentificationNumber)
        {

            return false;

        }

        public bool UserEmailExists(string userEmail)
        {

            return false;

        }

        public void DeleteUser(User user)
        {

            Console.WriteLine(user.UserIdentificationNumber);

        }

        public int UserHasRentedBooks(string userIdentificationNumber)
        {

            return 0;

        }

    }
}
