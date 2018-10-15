using Timers.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timers.Shared.Repositories
{
    public class MemoryGameSettingRepository : IRepository<GameSetting>
    {
        private List<GameSetting> Items { get; set; }

        public MemoryGameSettingRepository()
        {
            SeedItems();
        }

        void SeedItems()
        {
            Items = new List<GameSetting>();

            Items.Add(new GameSetting()
            {
                Id = new Guid("539624fd-c54a-4621-b182-b3136ee2121a"),
                Name = "Indoor Soccer",
                IsCountdown = false,
                MaxPlayersAllowed = 6,
                MinutesPerPeriod = 25,
                Periods = 2
            });
        }

        public Task<GameSetting> GetByIdAsync(Guid id)
        {
            var result = Items.Where(i => i.Id == id).SingleOrDefault();
            return Task.FromResult(result);
        }

        public Task<IEnumerable<GameSetting>> GetAllAsync()
        {
            return Task.FromResult(Items as IEnumerable<GameSetting>);
        }
    }
}
