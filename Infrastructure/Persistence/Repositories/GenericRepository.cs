using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class GenericRepository<TEntity> : RepositoryBase<TEntity>, IGenericRepository<TEntity> where TEntity : class
{ 
    internal AppDbContext _dbContext;
    internal DbSet<TEntity> _dbSet;

    public GenericRepository(AppDbContext dbContext) :  base(dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }
    
    public async Task<List<TResult>> GetListBySpec<TResult>(ISpecification<TEntity, TResult> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).ToListAsync(cancellationToken);
    }

    public async Task<TResult?> GetItemBySpec<TResult>(ISpecification<TEntity, TResult> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<TEntity?> GetByIdAsync(object id)
    {
        return await _dbSet.FindAsync(id);
        
    }

    public async Task InsertAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task InsertRangeAsync(IEnumerable<TEntity> entities)
    {
        await _dbSet.AddRangeAsync(entities);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(object id)
    {
        TEntity? entityToDelete = await _dbSet.FindAsync(id);
        if (entityToDelete != null)
        {
            await DeleteAsync(entityToDelete);
        }
        else
        {
            throw new ArgumentException($"Entity with id {id} not found.");
        }
    }

    public async Task DeleteAsync(TEntity entityToDelete)
    {
        if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            _dbSet.Attach(entityToDelete);
        }
        _dbSet.Remove(entityToDelete);
        await _dbContext.SaveChangesAsync();    
    }

    public async Task DeleteRangeAsync(IEnumerable<TEntity> entities)
    {
        foreach (var entity in entities)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
        }

        _dbSet.RemoveRange(entities);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entityToUpdate)
    {
        _dbSet.Attach(entityToUpdate);
        _dbContext.Entry(entityToUpdate).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }

    public async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
    {
        foreach (var entity in entities)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        await _dbContext.SaveChangesAsync();
    }
}