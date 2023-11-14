using Application.DTO;
using Application.UseCases.Commands.Product;
using Application.UseCases.Commands.Supplier;
using Implementation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        [HttpPost("add-supplier")]
        public IActionResult Post(
            [FromBody] AddSupplierDTO dto,
            [FromServices] IAddSupplierCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("update-supplier")]
        public IActionResult Put(
            [FromBody] UpdateSupplierDTO dto,
            [FromServices] IUpdateSupplierCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("delete-supplier")]
        public IActionResult Delete(
            [FromBody] DeleteSupplierDTO dto,
            [FromServices] IDeleteSupplierCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
