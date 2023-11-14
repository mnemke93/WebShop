using Application.DTO;
using Application.UseCases.Commands.Cart;
using Application.UseCases.Commands.Category;
using Implementation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        [HttpPost("add-cart")]
        public IActionResult Post(
            [FromBody] AddCartDTO dto,
            [FromServices] IAddCartCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("update-cart")]
        public IActionResult Put(
            [FromBody] UpdateCartDTO dto,
            [FromServices] IUpdateCartCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("delete-cart")]
        public IActionResult Delete(
            [FromBody] DeleteCartDTO dto,
            [FromServices] IDeleteCartCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
