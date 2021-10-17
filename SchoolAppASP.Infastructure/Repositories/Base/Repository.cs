//this class is for "that implements the interface for generic CRUD"

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolAppASP.Infastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Task<T> AddAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}