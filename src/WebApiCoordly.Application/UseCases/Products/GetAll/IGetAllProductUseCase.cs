using WebApiCoordly.Communication.Responses;

namespace WebApiCoordly.Application.UseCases.Products.GetAll
{
    public interface IGetAllProductUseCase
    {
        Task<ResponseProductJson> Execute();
    }
}
