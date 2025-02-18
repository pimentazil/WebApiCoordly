using AutoMapper;
using WebApiCoordly.Communication.Requests;
using WebApiCoordly.Communication.Responses;
using WebApiCoordly.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApiCoordly.Application.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            RequestToEntity();
            EntityToResponse();
        }

        private void RequestToEntity()
        {
            CreateMap<RequestRegisterProductJson, Product>();
        }

        private void EntityToResponse()
        {
            CreateMap<Product, ResponseRegisteredProductJson>();
            CreateMap<Product, ResponseShortProductJson>();
        }
    }
}
