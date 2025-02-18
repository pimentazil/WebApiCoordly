using WebApiCoordly.Communication.Requests;

namespace WebApiCoordly.Application.UseCases.Products.Update
{
    public interface IUpdateProductUseCase
    {
        Task Execute(int id, RequestRegisterProductJson request);
    }
}
