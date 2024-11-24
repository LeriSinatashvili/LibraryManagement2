using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Commands
{
    public class RegisterUserCommand
    {

        public string UserName { get; set; }
        public string UserIdentificationNumber { get; set; }
        public string UserEmail { get; set; }

        public void ValidateUser()
        {

            if (UserName.Length < 1 || UserName.Length > 100)
            {
                throw new Exception();
            }

            foreach (char character in UserIdentificationNumber)
            {
                if (character < '0' || character > '9')
                    throw new Exception();
            }

            if (UserIdentificationNumber.Length != 11)
            {
                throw new Exception();
            }

            if(UserEmail.Length > 100)
            {
                throw new Exception();
            }

            var trimmedEmail = UserEmail.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                throw new Exception();
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(UserEmail);
            }
            catch
            {
                throw new Exception();
            }

        }
    }

    public class DeleteUserCommand
    {

        public string UserIdentificationNumber { get; set; }

        public void ValidateUser()
        {

            foreach (char character in UserIdentificationNumber)
            {
                if (character < '0' || character > '9')
                    throw new Exception();
            }

            if (UserIdentificationNumber.Length != 11)
            {
                throw new Exception();
            }

        }
    }
}
