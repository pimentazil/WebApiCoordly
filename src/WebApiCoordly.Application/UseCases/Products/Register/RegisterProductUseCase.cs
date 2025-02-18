using AutoMapper;
using WebApiCoordly.Communication.Requests;
using WebApiCoordly.Communication.Responses;
using WebApiCoordly.Domain.Entities;
using WebApiCoordly.Domain.Repositories;
using WebApiCoordly.Domain.Repositories.Product;
using WebApiCoordly.Exception.ExceptionBase;

namespace WebApiCoordly.Application.UseCases.Products.Register
{
    public class RegisterProductUseCase : IRegisterProductUseCase
    {
        private readonly IProductWriteOnlyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RegisterProductUseCase(
            IProductWriteOnlyRepository repository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseRegisteredProductJson> Execute(RequestRegisterProductJson request)
        {
            Validate(request);

            var product = _mapper.Map<Product>(request);

            await _repository.Add(product);

            await _unitOfWork.Commit();

            return _mapper.Map<ResponseRegisteredProductJson>(product);
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
