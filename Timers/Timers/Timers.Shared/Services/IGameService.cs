using Timers.Shared.ViewModels;
using System;
using System.Threading.Tasks;

namespace Timers.Shared.Services
{
    public interface IGameService
    {
        //IEnumerable<GameVM> GetAll();
        //Game Add(Game newItem);
        Task<IGameVM> GetByIdAsync(Guid id);
        //void Remove(Guid id);
    }
}
