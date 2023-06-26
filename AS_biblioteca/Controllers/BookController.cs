using AS_biblioteca.Domain.Entities;
using AS_biblioteca.Domain.Interfaces;
using AS_biblioteca.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AS_biblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class BookController : ControllerBase
    {
        private readonly IBookRepository repository;

        public BookController()
        {
            this.repository = new BookRepository();
        }

        [HttpGet]
        [Route("GetBook")]
        public IEnumerable<Book>GetBook()
        {
            return repository.GetAll();
        }

        [HttpGet]
        [Route("GetBook/{id}")]
        public Book Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        [Route("CadastrarBook")]
        public IActionResult CadastrarBook([FromBody] Book item)
        {
            repository.Save(item);
            return Ok(new{
                statusCode = 200,
                massage = "Livro cadastrado com sucesso!",
                item
            });
        }

        [HttpDelete]
        [Route("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            repository.Delete(id);
            return Ok(new{
                statusCode = 200,
                message = "Livro deletado com sucesso!",
            });
        }

        [HttpPut]
        [Route("UpdateBook")]
        public IActionResult UpdateBook([FromBody] Book item)
        {
            repository.Update(item);
            return Ok(new{
                statusCode = 200,
                message = "Livro alterado com sucesso!",
                item
            });
        }
    }
}