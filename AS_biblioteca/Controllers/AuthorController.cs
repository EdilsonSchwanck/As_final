using AS_biblioteca.Domain.Entities;
using AS_biblioteca.Domain.Interfaces;
using AS_biblioteca.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AS_biblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository repository;

        public AuthorController()
        {
            this.repository = new AuthorRepository();
        }

        [HttpGet]
        [Route("GetAutores")]
        public IEnumerable<Author>GetAutores()
        {
            return repository.GetAll();
        }

        [HttpGet]
        [Route("GetAutor/{id}")]
        public Author Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        [Route("GetAutor")]
        public IActionResult GetAutor([FromBody] Author item)
        {
            repository.Save(item);
            return Ok(new{
                statusCode = 200,
                massage = "Autor cadastrado com sucesso!",
                item
            });
        }

        [HttpDelete]
        [Route("DeleteAutor/{id}")]
        public IActionResult DeleteAutor(int id)
        {
            repository.Delete(id);
            return Ok(new{
                statusCode = 200,
                message = "Autor deletado com sucesso!",
            });
        }

        [HttpPut]
        [Route("UpdateAutor")]
        public IActionResult UpdateAutor([FromBody] Author item)
        {
            repository.Update(item);
            return Ok(new{
                statusCode = 200,
                message = "Autor alterado com sucesso!",
                item
            });
        }
    }
}