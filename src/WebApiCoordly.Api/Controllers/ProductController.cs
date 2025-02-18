using Microsoft.AspNetCore.Mvc;
using WebApiCoordly.Application.UseCases.Products.Delete;
using WebApiCoordly.Application.UseCases.Products.GetAll;
using WebApiCoordly.Application.UseCases.Products.Register;
using WebApiCoordly.Application.UseCases.Products.Update;
using WebApiCoordly.Communication.Requests;
using WebApiCoordly.Communication.Responses;

namespace WebApiCoordly.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredProductJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register(
       [FromServices] IRegisterProductUseCase useCase,
       [FromBody] RequestRegisterProductJson request)
        {
            var response = await useCase.Execute(request);

            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseProductJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetAllExpenses([FromServices] IGetAllProductUseCase useCase)
        {
            var response = await useCase.Execute();

            if (response.Products.Count != 0)
                return Ok(response);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(
        [FromServices] IDeleteProductUseCase useCase,
        [FromRoute] int id)
        {
            await useCase.Execute(id);

            return NoContent();
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(
        [FromServices] IUpdateProductUseCase useCase,
        [FromRoute] int id,
        [FromBody] RequestRegisterProductJson request)
        {
            await useCase.Execute(id, request);

            return NoContent();
        }
    }
}
