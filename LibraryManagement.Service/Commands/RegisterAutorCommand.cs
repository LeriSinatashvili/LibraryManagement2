using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Commands
{
    public class RegisterAutorCommand
    {

        public string AutorName { get; set; }
        public int AutorBirthYear { get; set; }
        public string AutorBiography { get; set; }

        public void ValidateAutor()
        {

            if(AutorName.Length < 1 || AutorName.Length > 100)
            {
                throw new Exception();
            }

            DateTime currentYear = new DateTime();

            if(AutorBirthYear <= currentYear.Year)
            {
                throw new Exception();
            }

        }

    }

    public class DeleteAutorCommand
    {

        public string AutorName { get; set; }

        public void ValidateAutor()
        {

            if (AutorName.Length < 1 || AutorName.Length > 100)
            {
                throw new Exception();
            }

        }
    }

    public class EditAutorCommand
    {
        public string AutorName { get; set; }
        public int AutorBirthYear { get; set; }
        public string AutorBiography { get; set; }

        public void ValidateAutor()
        {

            if (AutorName.Length < 1 || AutorName.Length > 100)
            {
                throw new Exception();
            }

            DateTime currentYear = new DateTime();

            if (AutorBirthYear <= currentYear.Year)
            {
                throw new Exception();
            }

        }


    }
}
