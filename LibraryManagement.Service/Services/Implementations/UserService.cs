using LibraryManagement.Service.Commands;
using LibraryManagement.Service.Models;
using LibraryManagement.Service.Services.Abstractions;
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

        public void ExecuteRegisterUser(RegisterUserCommand command)
        {


            command.ValidateUser();

            bool userIdentificationNumberExists = _userRepository.UserIdentificationNumberExists(command.UserIdentificationNumber);
            if (userIdentificationNumberExists)
            {
                throw new Exception();
            }

            bool userEmailExists = _userRepository.UserEmailExists(command.UserEmail);
            if (userEmailExists)
            {
                throw new Exception();
            }

            var newUser = new User();

            newUser.UserName = command.UserName;
            newUser.UserIdentificationNumber = command.UserIdentificationNumber;
            newUser.UserEmail = command.UserEmail;

            _userRepository.RegisterUser(newUser);

        }

        public void ExecuteDeleteUser(DeleteUserCommand command)
        {
            command.ValidateUser();

            bool userIdentificationNumberExists = _userRepository.UserIdentificationNumberExists(command.UserIdentificationNumber);
            if (!userIdentificationNumberExists)
            {
                throw new Exception();
            }
            int userHasRentedBooks = _userRepository.UserHasRentedBooks(command.UserIdentificationNumber);
            if (userHasRentedBooks > 0)
            {
                throw new Exception();
            }


            var newUser = new User();

            newUser.UserIdentificationNumber = command.UserIdentificationNumber;


            _userRepository.DeleteUser(newUser);

        }


    }
}
