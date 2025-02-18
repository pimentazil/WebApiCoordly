using AutoMapper;
using WebApiCoordly.Communication.Responses;
using WebApiCoordly.Domain.Repositories.Product;

namespace WebApiCoordly.Application.UseCases.Products.GetAll
{
    public class GetAllProductUseCase : IGetAllProductUseCase
    {
        private readonly IProductWriteOnlyRepository _repository;
        private readonly IMapper _mapper;

        public GetAllProductUseCase(IProductWriteOnlyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResponseProductJson> Execute()
        {
            var result = await _repository.GetAll();

            return new ResponseProductJson
            {
                Products = _mapper.Map<List<ResponseShortProductJson>>(result)
            };
        }
    }
}
