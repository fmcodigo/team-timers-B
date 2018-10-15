using Timers.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timers.Shared.Repositories
{
    public class MemoryPlayerRepository : IPlayerRepository<Player>
    {
        private List<Player> Items { get; set; }
        public MemoryPlayerRepository()
        {
            SeedItems();
        }

        void SeedItems()
        {
            Items = new List<Player>();

            var GalaxyTeamGuid = new Guid("aa17ac7b-3e35-4182-9ae3-a572500b0aff");

            Items.Add(new Player()
            {
                Id = new Guid( "571cea5a-88ce-42fc-8a31-cd70a2a00cc8"),
                Jersey = "10",
                Name = "Messi",
                TeamId = GalaxyTeamGuid
            });

            Items.Add(new Player()
            {
                Id = new Guid("cda5f906-3142-4eda-bcee-bf65cf13e941"),
                Jersey = "7",
                Name = "Ronaldo",
                TeamId = GalaxyTeamGuid
            });

            Items.Add(new Player()
            {
                Id = new Guid("f20d9d7b-529e-46f5-b490-9d44e84d37c5"),
                Jersey = "5",
                Name = "Medel",
                TeamId = GalaxyTeamGuid
            });

            Items.Add(new Player()
            {
                Id = new Guid("8f380410-cc5c-4982-b230-dcc7e2c17484"),
                Jersey = "6",
                Name = "Diaz",
                TeamId = GalaxyTeamGuid
            });

            Items.Add(new Player()
            {
                Id = new Guid("fa9476fd-eea1-4871-988f-4a956e7f4503"),
                Jersey = "4",
                Name = "Isla",
                TeamId = GalaxyTeamGuid
            });

            Items.Add(new Player()
            {
                Id = new Guid("69df9a11-eb0c-430f-9419-deb398ded28e"),
                Jersey = "20",
                Name = "Aranguiz",
                TeamId = GalaxyTeamGuid
            });

            Items.Add(new Player()
            {
                Id = new Guid("4bcfc0ad-4ae7-4000-8f16-881c390cdc50"),
                Jersey = "11",
                Name = "Neymar",
                TeamId = GalaxyTeamGuid
            });

            Items.Add(new Player()
            {
                Id = new Guid("312db445-94b9-4518-b993-141710f2d716"),
                Jersey = "1",
                Name = "Bravo",
                TeamId = GalaxyTeamGuid
            });
        }

        public Task<Player> GetByIdAsync(Guid id)
        {
            var result = Items.Where(i => i.Id == id).SingleOrDefault();
            return Task.FromResult(result);
        }

        public Task<IEnumerable<Player>> GetAllAsync()
        {
            return Task.FromResult(Items as IEnumerable<Player>);
        }

        public Task<IEnumerable<Player>> GetItemsByIdAsync(Guid teamId)
        {
            var results  = Items.Where(i => i.TeamId == teamId).ToList();
            return Task.FromResult(results as IEnumerable<Player>);
        }
    }
}
