using Application.DTO;
using Application.UseCases.Commands.Order;
using Application.UseCases.Commands.Product;
using Implementation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpPost("add-order")]
        public IActionResult Post(
            [FromBody] AddOrderDTO dto,
            [FromServices] IAddOrderCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("update-order")]
        public IActionResult Put(
            [FromBody] UpdateOrderDTO dto,
            [FromServices] IUpdateOrderCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("delete-order")]
        public IActionResult Delete(
            [FromBody] DeleteOrderDTO dto,
            [FromServices] IDeleteOrderCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
