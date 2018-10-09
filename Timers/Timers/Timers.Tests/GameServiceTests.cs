using Microsoft.Extensions.DependencyInjection;
using Timers.Shared.Services;
using Timers.Shared.ViewModels;
using System;
using Xunit;
using System.Threading.Tasks;

namespace Timers.Tests
{
    [Collection("DI collection")]
    public class GameServiceTests
    {
        private readonly IGameService _gameService;
        public GameVM _gameVM { get; private set; }

        public GameServiceTests(FixtureDI fixture)
        {
            var serviceProvider = fixture.ServiceProvider;
            _gameService = serviceProvider.GetService<IGameService>();
        }

        async Task InitializeGameAsync()
        {
            if (_gameVM == null)
                _gameVM = await _gameService.GetByIdAsync(new Guid("d66945ca-e9ef-4b5b-8084-35ea568d937c"));
        }

        [Fact]
        public async Task HomeTeamName_ShouldBe_Galaxy()
        {
            await InitializeGameAsync();
            var homeTeamName = _gameVM.HomeTeam.Name;

            Assert.Equal("Galaxy", homeTeamName);
        }

        [Fact]
        public  async Task VisitorTeamName_ShouldBe_DCUnited()
        {
            await InitializeGameAsync();
            var visitorTeamName = _gameVM.VisitorTeam.Name;

            Assert.Equal("DC United", visitorTeamName);
        }

        [Fact]
        public async Task GameSettingName_ShouldBe_IndoorSoccer()
        {
            await InitializeGameAsync();
            var gameSettingName = _gameVM.GameSetting.Name;

            Assert.Equal("Indoor Soccer", gameSettingName);
        }

    }

}

