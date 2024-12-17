using LibraryManagement.Service.Commands;
using LibraryManagement.Service.Models;

namespace LibraryManagement.Service.Services.Abstractions
{
    public interface IUserRepository
    {
        Task RegisterUser(User user);

        Task<bool> UserIdentificationNumberExists(string userIdentificationNumber);

        Task<bool> UserEmailExists(string userIdentificationNumber);

        Task DeleteUser(string userIdentificationNumber);

        Task<int> UserHasRentedBooks(string userIdentificationNumber);

    }
}
