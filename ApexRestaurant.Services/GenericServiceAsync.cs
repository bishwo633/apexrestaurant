using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using ApexRestaurant.Repository;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Services
{
    public abstract class GenericServiceAsync<T> : IGenericServiceAsync<T>
        where T : class, new()
    {

        protected IGenericRepositoryAsync<T> EntityRepository { get; }

        protected GenericServiceAsync(IGenericRepositoryAsync<T> entityRepository)
        {
            EntityRepository = entityRepository;
        }

        public async Task Insert(T entity)
        {
            await EntityRepository.Insert(entity);
        }

        public async Task Update(T entity)
        {
            await EntityRepository.Update(entity);
        }

        public async Task<IList<T>> GetAll()
        {
            return await Task.FromResult(EntityRepository.Query().ToList());
        }

        public async Task<T> GetById(int id)
        {
            return await EntityRepository.Get(id);
        }

        public async Task Delete(T entity)
        {
            var role = "admin";
            if (role == "admin")
            {
                await EntityRepository.Delete(entity);
                return;
            }
            throw new InvalidCredentialException("You have no rights to delete");
        }
    }
}