using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Timers.Shared.Repositories
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        //void Add(T entity);
        //void Delete(T entity);
        //void Edit(T entity);
    }

}
