using LibraryManagement.Service.Commands;
using LibraryManagement.Service.Models;
using LibraryManagement.Service.Services.Abstractions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services.Implementations
{
    public class UserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task ExecuteRegisterUser(RegisterUserCommand command)
        {


            command.ValidateUser();

            bool userIdentificationNumberExists = await _userRepository.UserIdentificationNumberExists(command.UserIdentificationNumber);
            if (userIdentificationNumberExists)
            {
                throw new Exception("User Identification Number Already Exists");
            }

            bool userEmailExists = await _userRepository.UserEmailExists(command.UserEmail);
            if (userEmailExists)
            {
                throw new Exception("User Email Already Exists");
            }

            var newUser = new User();

            newUser.UserName = command.UserName;
            newUser.UserIdentificationNumber = command.UserIdentificationNumber;
            newUser.UserEmail = command.UserEmail;

            await _userRepository.RegisterUser(newUser);

        }

        public async Task ExecuteDeleteUser(DeleteUserCommand command)
        {
            command.ValidateUser();

            bool userIdentificationNumberExists = await _userRepository.UserIdentificationNumberExists(command.UserIdentificationNumber);
            if (!userIdentificationNumberExists)
            {
                throw new Exception("User Does Not Exist");
            }

            int userHasRentedBooks = await _userRepository.UserHasRentedBooks(command.UserIdentificationNumber);
            if (userHasRentedBooks > 0)
            {
                throw new Exception("User Has Rented Books");
            }

            await _userRepository.DeleteUser(command.UserIdentificationNumber);

        }


    }
}
