using WebApiCoordly.Domain.Repositories;
using WebApiCoordly.Domain.Repositories.Product;

namespace WebApiCoordly.Application.UseCases.Products.Delete
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductWriteOnlyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductUseCase(
            IProductWriteOnlyRepository repository,
            IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(int id)
        {
            await _repository.Delete(id);

            await _unitOfWork.Commit();
        }
    }
}
