//this class is for "that implements the interface for generic CRUD"

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolAppASP.Infastructure.Data;

namespace SchoolAppASP.Infastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly UserContext _userContext;

        public Repository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _userContext.Set<T>().AddAsync(entity);
            await _userContext.SaveChangesAsync();
            return entity;
            //throw new System.NotImplementedException();
        }

        public async Task DeleteAsync(T entity)
        {
            _userContext.Set<T>().Remove(entity);
            await _userContext.SaveChangesAsync();
            //throw new System.NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _userContext.Set<T>().ToListAsync();
            //throw new System.NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _userContext.Set<T>().FindAsync(id);
            //throw new System.NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}