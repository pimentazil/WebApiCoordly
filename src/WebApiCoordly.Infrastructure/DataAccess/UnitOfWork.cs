using WebApiCoordly.Domain.Repositories;

namespace WebApiCoordly.Infrastructure.DataAccess
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly CoordlyDbContext _dbContext;
        public UnitOfWork(CoordlyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Commit() => await _dbContext.SaveChangesAsync();
    }
}
