using Application.DTO;
using Application.UseCases.Commands.User;
using Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UsersController : Controller
    {
        [HttpPost("add-user")]
        public IActionResult Post(
            [FromBody] AddUserDTO dto,
            [FromServices] IAddUserCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("update-user")]
        public IActionResult Put(
            [FromBody] UpdateUserDTO dto,
            [FromServices] IUpdateUserCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("delete-user")]
        public IActionResult Delete(
            [FromBody] DeleteUserDTO dto,
            [FromServices] IDeleteUserCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

    }
}
