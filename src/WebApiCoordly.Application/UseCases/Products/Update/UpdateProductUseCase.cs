using AutoMapper;
using WebApiCoordly.Communication.Requests;
using WebApiCoordly.Domain.Repositories;
using WebApiCoordly.Domain.Repositories.Product;
using WebApiCoordly.Exception.ExceptionBase;

namespace WebApiCoordly.Application.UseCases.Products.Update
{
    public class UpdateProductUseCase : IUpdateProductUseCase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductWriteOnlyRepository _repository;

        
        public UpdateProductUseCase(
            IMapper mapper
            ,IUnitOfWork unitOfWork
            ,IProductWriteOnlyRepository repository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task Execute(int ProductID, RequestRegisterProductJson request)
        {
            Validate(request);

            var product = await _repository.GetById(ProductID);

            if (product is null)
            {
                throw new NotFoundException(ResourceErrorMessages.PRODUCT_NOT_FOUND);
            }

            _mapper.Map(request, product);

            _repository.Update(product);

            await _unitOfWork.Commit();
        }

        private void Validate(RequestRegisterProductJson request)
        {
            var validator = new ProductValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

                throw new ErrorOnValidationException(errorMessages);
            }
        }
    }
}
