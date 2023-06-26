using AS_biblioteca.Configuration;
using AS_biblioteca.Domain.DTOs;
using AS_biblioteca.Domain.Entities;
using AS_biblioteca.Domain.Interfaces;
using AS_biblioteca.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AS_biblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly IUserRepository repository;
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            this.repository = new UserRepository();
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetUsuarios")]
        public IEnumerable<UserDTO>GetUsuarios()
        {        
           return _mapper.Map<List<User>,List<UserDTO>>(repository.GetAllWithInclude());
        }

        [HttpGet]
        [Route("GetUsuario/{id}")]
        public User Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        [Route("CadastrarUsuario")]
        public IActionResult CadastrarUsuario([FromBody] User item)
        {
            repository.Save(item);
            return Ok(new{
                statusCode = 200,
                massage = "Autor cadastrado com sucesso!",
                item
            });
        }

        [HttpDelete]
        [Route("DeleteUsuario/{id}")]        
        public IActionResult DeleteUsuario(int id)
        {
            repository.Delete(id);
            return Ok(new{
                statusCode = 200,
                message = "Autor deletado com sucesso!",
            });
        }

        [HttpPut]
        [Route("UpdateUsuario")]        
        public IActionResult UpdateUsuario([FromBody] User item)
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