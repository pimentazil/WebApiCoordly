using WebApiCoordly.Communication.Requests;
using WebApiCoordly.Communication.Responses;

namespace WebApiCoordly.Application.UseCases.Products.Register
{
    public interface IRegisterProductUseCase
    {
        Task<ResponseRegisteredProductJson> Execute(RequestRegisterProductJson request);
    }
}
