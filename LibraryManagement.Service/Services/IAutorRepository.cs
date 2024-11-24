using LibraryManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services
{
    public interface IAutorRepository
    {

        void RegisterAutor(Autor autor);

        bool AutorNameExists(string autorName);

        void DeleteAutor(Autor autor);

        int AutorHasBooks(string autorName);

        int GetAutorId(string autorName);

        void UpdateAutor(Autor autor);

    }
}
