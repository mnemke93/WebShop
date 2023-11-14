using Application.DTO;
using Application.UseCases.Commands.Category;
using Application.UseCases.Commands.Product;
using Implementation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpPost("add-category")]
        public IActionResult Post(
            [FromBody] AddCategoryDTO dto,
            [FromServices] IAddCategoryCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("update-category")]
        public IActionResult Put(
            [FromBody] UpdateCategoryDTO dto,
            [FromServices] IUpdateCategoryCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("delete-category")]
        public IActionResult Delete(
            [FromBody] DeleteCategoryDTO dto,
            [FromServices] IDeleteCategoryCommand command,
            [FromServices] UseCaseHandler handler
            )
        {
            handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
