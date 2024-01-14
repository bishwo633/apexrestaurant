using System.Linq;

namespace ApexRestaurant.Repository;

public interface IGenericRepositoryAsync<T>
{

    /// <summary>
    /// Get
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<T> Get(int id);

    /// <summary>
    /// Query
    /// </summary>
    /// <returns></returns>
    IQueryable<T> Query();

    /// <summary>
    /// Insert
    /// </summary>
    /// <param name="entity"></param>
    Task Insert(T entity);

    /// <summary>
    /// Update
    /// </summary>
    /// <param name="entity"></param>
    Task Update(T entity);

    /// <summary>
    /// Delete
    /// </summary>
    /// <param name="entity"></param>
    Task Delete(T entity);

}