namespace WebApiCoordly.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
