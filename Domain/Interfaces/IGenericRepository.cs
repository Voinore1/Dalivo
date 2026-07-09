using Ardalis.Specification;

namespace Domain.Interfaces;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<List<TResult>> GetListBySpec<TResult>(ISpecification<TEntity, TResult> specification, CancellationToken cancellationToken = default);
    Task<TResult?> GetItemBySpec<TResult>(ISpecification<TEntity, TResult> specification, CancellationToken cancellationToken = default);

    Task<TEntity?> GetByIdAsync(object id);
    Task InsertAsync(TEntity entity);
    Task InsertRangeAsync(IEnumerable<TEntity> entities);
    Task DeleteAsync(object id);
    Task DeleteAsync(TEntity entity);
    Task DeleteRangeAsync(IEnumerable<TEntity> entities);
    Task UpdateAsync(TEntity entity);
    Task SaveAsync();
    Task UpdateRangeAsync(IEnumerable<TEntity> entities);
}