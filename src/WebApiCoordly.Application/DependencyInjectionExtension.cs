using Microsoft.Extensions.DependencyInjection;
using WebApiCoordly.Application.AutoMapper;
using WebApiCoordly.Application.UseCases.Products.Delete;
using WebApiCoordly.Application.UseCases.Products.GetAll;
using WebApiCoordly.Application.UseCases.Products.Register;
using WebApiCoordly.Application.UseCases.Products.Update;

namespace WebApiCoordly.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddAutoMapper(services);
            AddUseCases(services);
        }

        private static void AddAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<IRegisterProductUseCase, RegisterProductUseCase>();
            services.AddScoped<IGetAllProductUseCase, GetAllProductUseCase>();
            services.AddScoped<IDeleteProductUseCase, DeleteProductUseCase>();
            services.AddScoped<IUpdateProductUseCase, UpdateProductUseCase>();
        }
    }
}
