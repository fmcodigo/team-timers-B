using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Timers.Shared.Repositories
{
    public interface IPlayerRepository<T> : IRepository<T>
    {
        Task<IEnumerable<T>> GetItemsByIdAsync(Guid teamId);
    }
}
