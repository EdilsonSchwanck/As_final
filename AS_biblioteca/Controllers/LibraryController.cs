using AS_biblioteca.Domain.DTOs;
using AS_biblioteca.Domain.Entities;
using AS_biblioteca.Domain.Interfaces;
using AS_biblioteca.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AS_biblioteca.Controllers
{
    public class LibraryController : ControllerBase
    {
        public readonly IMapper _mapper;
        public readonly ILibraryRepository repository;
        public LibraryController(IMapper mapper)
        {
            _mapper = mapper;
            repository = new LibraryRepository();
        }

        [HttpPost]
        [Route("EmprestarLivro")]
        public IActionResult EmprestarLivro([FromBody] LibraryEmprestarDTO item)
        {
            repository.Save( _mapper.Map<LibraryEmprestarDTO,Library>(item));
                return Ok(new{
                    statusCode = 200,
                    message = "Livro emprestado com successo!",
                });
        }

        
        [HttpPost]
        [Route("DevolverLivro")]
        public IActionResult DevolverLivro([FromBody] LibraryDevolverDTO item)
        {
            repository.Save(_mapper.Map<LibraryDevolverDTO,Library>(item));
                return Ok(new{
                    statusCode = 200,
                    message = "Livro devolvido com successo!",
                });
        }

    }
}