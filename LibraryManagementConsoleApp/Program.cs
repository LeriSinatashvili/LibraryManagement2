using LibraryManagement.Service.Commands;
using LibraryManagement.Service.Services;

namespace LibraryManagementConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var registerUserComman = new RegisterUserCommand
            {

                UserName = "John",
                UserIdentificationNumber = "11111111111",
                UserEmail = "email@mail.com"

            };

            var deleteUserComman = new DeleteUserCommand
            {

                UserIdentificationNumber = "22222222222"

            };


            //var userService = new UserService(new UserRepository());
            //userService.ExecuteRegisterUser(registerUserComman);
            //userService.ExecuteDeleteUser(deleteUserComman);


            var registerAutorCommand = new RegisterAutorCommand()
            {

                AutorName = "New Autor",
                AutorBirthYear = 1998,
                AutorBiography = ""

            };

            var deleteAutorCommand = new DeleteAutorCommand()
            {
                AutorName = "Old Autor"
            };

            var updateAutorCommand = new EditAutorCommand()
            {

                AutorName = "Really New Autor",
                AutorBirthYear = 1997,
                AutorBiography = "something here"

            };

            var autorService = new AutorService(new AutorRepository());
            //autorService.ExecuteRegisterAutor(registerAutorCommand);
            //autorService.ExecuteDeleteAutor(deleteAutorCommand);
            //autorService.ExecuteEditAutor(updateAutorCommand);



            var registerBook = new RegisterBookCommand()
            {

                BookTitle = "Book1",
                BookPublicationDate = DateTime.Parse("Jan 1, 2009"),
                BookAutor = "Autor1",
                BookPagesNumber = 55,
                BookDescription = "Description1",
                BookQuantity = 50

            };

            var editBook = new EditBookCommand()
            {

                BookTitle = "New Book1",
                BookPublicationDate = DateTime.Parse("Jan 5, 2008"),
                BookAutor = "Autor5",
                BookPagesNumber = 75,
                BookDescription = "Description1"

            };

            var deleteBook = new DeleteBookCommand()
            {

                BookTitle = "Old Book"

            };

            var bookService = new BookService(new BookRepository());
            //bookService.ExecuteRegisterBook(registerBook);
            //bookService.ExecuteEditBook(editBook);
            bookService.ExecuteDeleteBook(deleteBook);


            var rentBook = new RentBookCommand()
            {

                RentUserIdentificationNumber = "12121212121",
                RentBookTitle = "Some Book7",
                RentBookRentingDate = DateTime.Now,
                RentBookReturningDate = null

            };

            var returnBook = new RentReturnBookCommand()
            {

                RentUserIdentificationNumber = "12121212121",
                RentBookTitle = "Some Book7",
                RentBookReturningDate = DateTime.Now

            };

            var rentBookService = new RentBookService(new RentBookRepository());
            //rentBookService.ExecuteRentBookRenting(rentBook);
            //rentBookService.ExecuteRentBookReturning(returnBook);

        }
    }
}
