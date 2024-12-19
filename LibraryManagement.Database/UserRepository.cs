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

        public async Task RegisterUser(User user)
        {


            using (var context = new LibraryManagementContext())
            {

                var newUser = new User();

                newUser.UserName = user.UserName;
                newUser.UserIdentificationNumber = user.UserIdentificationNumber;
                newUser.UserEmail = user.UserEmail;
                newUser.UserHasRentedBook = 0;

                await context.Database.ExecuteSqlRawAsync("Insert Into Users Values(@UserName, @UserIdentificationNumber, @UserEmail, @UserHasRentedBook)",
                    new SqlParameter("@UserName", newUser.UserName),
                    new SqlParameter("@UserIdentificationNumber", newUser.UserIdentificationNumber),
                    new SqlParameter("@UserEmail", newUser.UserEmail),
                    new SqlParameter("@UserHasRentedBook", newUser.UserHasRentedBook));

            }

        }

        public async Task<bool> UserIdentificationNumberExists(string userIdentificationNumber)
        {

            int countUserIdentificationNumber = 0;

            using (var context = new LibraryManagementContext())
            {

                countUserIdentificationNumber =  await context.Users.CountAsync(u => u.UserIdentificationNumber == userIdentificationNumber);

            }

            if (countUserIdentificationNumber > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<bool> UserEmailExists(string userEmail)
        {

            int countUserEmail = 0;

            using (var context = new LibraryManagementContext())
            {

                countUserEmail = await context.Users.CountAsync(u => u.UserEmail == userEmail);

            }

            if (countUserEmail > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task DeleteUser(string userIdentificationNumber)
        {

            using (var context = new LibraryManagementContext())
            {

                await context.Database.ExecuteSqlRawAsync("Delete From Users Where UserIdentificationNumber = @UserIdentificationNumber",
                    new SqlParameter("@UserIdentificationNumber", userIdentificationNumber));

            }

        }

        public async Task<int> UserHasRentedBooks(string userIdentificationNumber)
        {

            int userHasRentedBooks = 0;

            using (var context = new LibraryManagementContext())
            {

                var result = await context.Users
                            .Where(u => u.UserIdentificationNumber == userIdentificationNumber)
                            .Select(u => u.UserHasRentedBook)
                            .FirstOrDefaultAsync();

                userHasRentedBooks = result;

            }

            return userHasRentedBooks;

        }

    }
}
