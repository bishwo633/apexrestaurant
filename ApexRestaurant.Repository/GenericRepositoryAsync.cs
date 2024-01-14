using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository;

public abstract class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T>
where T : class, new()
{
    protected RestaurantContext DbContext { get; set; }

    public async Task<T> Get(int id)
    {
        return await DbContext.FindAsync<T>(id);
    }

    public IQueryable<T> Query()
    {
        return DbContext.Set<T>().AsQueryable();
    }

    public async Task Insert(T entity)
    {
        await DbContext.Set<T>().AddAsync(entity);
        await DbContext.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        DbContext.Entry(entity).State = EntityState.Modified;
        await DbContext.SaveChangesAsync();
    }

    public async Task Delete(T entity)
    {
        DbContext.Set<T>().Remove(entity);
        await DbContext.SaveChangesAsync();
    }
}