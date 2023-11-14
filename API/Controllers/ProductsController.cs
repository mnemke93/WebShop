using Application.DTO;
using Application.UseCases.Commands.Product;
using Application.UseCases.Commands.User;
using Implementation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost("add-product")]
        public IActionResult Post(
            [FromBody] AddProductDTO dto,
            [FromServices] IAddProductCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("update-product")]
        public IActionResult Put(
            [FromBody] UpdateProductDTO dto,
            [FromServices] IUpdateProductCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("delete-product")]
        public IActionResult Delete(
            [FromBody] DeleteProductDTO dto,
            [FromServices] IDeleteProductCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
