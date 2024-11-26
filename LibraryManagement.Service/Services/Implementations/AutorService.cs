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
    public class AutorService
    {

        private readonly IAutorRepository _autorRepository;

        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public void ExecuteRegisterAutor(RegisterAutorCommand command)
        {


            command.ValidateAutor();

            bool userAutorNameExists = _autorRepository.AutorNameExists(command.AutorName);
            if (userAutorNameExists)
            {
                throw new Exception();
            }


            var autor = new Autor();

            autor.AutorName = command.AutorName;
            autor.AutorBirthYear = command.AutorBirthYear;
            autor.AutorBiography = command.AutorBiography;

            _autorRepository.RegisterAutor(autor);

        }

        public void ExecuteDeleteAutor(DeleteAutorCommand command)
        {

            command.ValidateAutor();

            bool autorNameExists = _autorRepository.AutorNameExists(command.AutorName);
            if (!autorNameExists)
            {
                throw new Exception();
            }
            int autorHasBooks = _autorRepository.AutorHasBooks(command.AutorName);
            if (autorHasBooks > 0)
            {
                throw new Exception();
            }

            var autor = new Autor();

            autor.AutorName = command.AutorName;

            _autorRepository.DeleteAutor(autor);

        }

        public void ExecuteEditAutor(EditAutorCommand command)
        {

            command.ValidateAutor();

            bool autorNameExists = _autorRepository.AutorNameExists(command.AutorName);
            if (!autorNameExists)
            {
                throw new Exception();
            }

            int autorId = _autorRepository.GetAutorId(command.AutorName);


            var newAutor = new Autor();

            newAutor.AutorId = autorId;
            newAutor.AutorName = command.AutorName;
            newAutor.AutorBirthYear = command.AutorBirthYear;
            newAutor.AutorBiography = command.AutorBiography;

            _autorRepository.UpdateAutor(newAutor);

        }

    }
}
