﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timers.Shared.Models;

namespace Timers.Shared.Repositories
{
    public class MemoryTeamRepository : IRepository<ITeam>
    {
        public List<ITeam> Items { get; set; }

        public MemoryTeamRepository()
        {
            SeedItems();
        }

        void SeedItems()
        {
            Items = new List<ITeam>();

            Items.Add(new Team
            {
                Id = new Guid("aa17ac7b-3e35-4182-9ae3-a572500b0aff"),
                Name = "Galaxy"
            });
            Items.Add(new Team
            {
                Id = new Guid("9b9ad7b6-88f7-48f4-bb70-8f4b71374f44"),
                Name = "DC United"
            });
        }

        public Task<ITeam> GetByIdAsync(Guid id)
        {
            var result = Items.Where(i => i.Id == id).SingleOrDefault();
            return Task.FromResult(result);
        }

        public Task<IEnumerable<ITeam>> GetAllAsync()
        {
            return Task.FromResult(Items as IEnumerable<ITeam>);
        }
    }
}
