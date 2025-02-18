using System.Transactions;

namespace WebApiCoordly.Domain.Repositories.Product
{
    public interface IProductWriteOnlyRepository
    {
        Task<List<Entities.Product>> GetAll();
        Task Add(Entities.Product product);
        Task Delete(int ProductID);
        Task<Entities.Product> GetById(int ProductID); 
        void Update(Entities.Product product);
    }
}
