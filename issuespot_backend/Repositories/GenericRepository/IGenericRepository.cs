namespace issuespot_backend.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task CreateAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task<List<TEntity>> GetAllAsync();

        Task DeleteAsync(TEntity entity);
    }
}
