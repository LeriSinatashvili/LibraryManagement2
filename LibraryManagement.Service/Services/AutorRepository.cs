using LibraryManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services
{
    public class AutorRepository : IAutorRepository
    {

        public void RegisterAutor(Autor autor)
        {


            Console.WriteLine(autor.AutorName);


        }

        public bool AutorNameExists(string autorName)
        {
            return false;
        }

        public void DeleteAutor(Autor autor)
        {
            Console.WriteLine(autor.AutorName);
        }

        public int AutorHasBooks(string autorName)
        {
            return 0;
        }

        public int GetAutorId(string autorName)
        {
            return 1;
        }

        public void UpdateAutor(Autor autor)
        {

            Console.WriteLine(autor.AutorId);
            Console.WriteLine(autor.AutorName);
            Console.WriteLine(autor.AutorBirthYear);
            Console.WriteLine(autor.AutorBiography);

        }

    }
}
