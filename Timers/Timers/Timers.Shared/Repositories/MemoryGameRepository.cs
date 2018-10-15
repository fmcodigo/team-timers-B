using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timers.Shared.Models;

namespace Timers.Shared.Repositories
{
    public class MemoryGameRepository : IRepository<Game>
    {
        private List<Game> Items { get; set; }

        public MemoryGameRepository()
        {
            SeedItems();
        }

        void SeedItems()
        {
            Items = new List<Game>();

            Items.Add(new Game
            {
                Id = new Guid("d66945ca-e9ef-4b5b-8084-35ea568d937c"),
                HomeTeamId = new Guid("aa17ac7b-3e35-4182-9ae3-a572500b0aff"),  //Galaxy
                VisitorTeamId = new Guid("9b9ad7b6-88f7-48f4-bb70-8f4b71374f44"), //DC United
                GameSettingId = new Guid("539624fd-c54a-4621-b182-b3136ee2121a") //Indoor Soccer
            });

        }

        public Task<Game> GetByIdAsync(Guid id)
        {
            var result = Items.Where(i => i.Id == id).SingleOrDefault();
            return Task.FromResult(result);
        }

        public Task<IEnumerable<Game>> GetAllAsync()
        {
            return Task.FromResult(Items as IEnumerable<Game>);
        }
    }
}
