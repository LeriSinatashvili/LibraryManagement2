using LibraryManagement.Service.Commands;
using LibraryManagement.Service.Models;

namespace LibraryManagement.Service.Services.Abstractions
{
    public interface IUserRepository
    {
        void RegisterUser(User user);

        bool UserIdentificationNumberExists(string userIdentificationNumber);

        bool UserEmailExists(string userIdentificationNumber);

        void DeleteUser(User user);

        int UserHasRentedBooks(string userIdentificationNumber);

    }
}
