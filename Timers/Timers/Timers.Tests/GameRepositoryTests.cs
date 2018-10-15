using Timers.Shared.Repositories;
using Timers.Shared.Models;
using System;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Timers.Tests
{
    [Collection("DI collection")]
    public class GameRepositoryTests
    {
        private readonly IRepository<Game> _gameRepository;

        public GameRepositoryTests(FixtureDI fixture)
        {
            var serviceProvider = fixture.ServiceProvider;
            _gameRepository = serviceProvider.GetService<IRepository<Game>>();

        }

        [Fact]
        public async Task HomeTeamId_ShouldBe_GalaxyId()
        {
            var game = await _gameRepository.GetByIdAsync(new Guid("d66945ca-e9ef-4b5b-8084-35ea568d937c"));

            var homeTeamId = game.HomeTeamId;
            var teamId = new Guid("aa17ac7b-3e35-4182-9ae3-a572500b0aff"); //Galaxy
            Assert.Equal(teamId, homeTeamId);
        }

    }
}
