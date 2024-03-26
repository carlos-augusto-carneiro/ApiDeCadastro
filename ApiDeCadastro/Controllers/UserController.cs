using ApiDeCadastro.Aplication.UseCase.UserCase.AddUser;
using ApiDeCadastro.Aplication.UseCase.UserCase.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiDeCadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddUser")]
        public IActionResult AddedUser(AddUserRequest request)
        {
            var validador = new AddUserValidation();
            var validarValidador = validador.Validate(request);
            if (validarValidador.IsValid)
            {
                var result = _mediator.Send(request);
                return Ok(result);
            }
            else
            {
                return BadRequest("Usuario não adicionado");
            }
        }

        [HttpPut("UpdateUser/{id}")]
        public IActionResult UpdateUser(UpdateUserRequest request)
        {
            var validador = new UpdateUserValidation();
            var validarValidador = validador.Validate(request);
            if(validarValidador.IsValid)
            {
                var result = _mediator.Send(request);
                return Ok(result);
            }
            else
            {
                return BadRequest("Nao foi possivel fazer a validacao");
            }
        }
    }
}
