using AutoMapper;
using Timers.Shared.Repositories;
using Timers.Shared.Models;
using Timers.Shared.ViewModels;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Timers.Shared.Services
{
    public class GameService : IGameService
    {
        private readonly IMapper _mapper;

        private readonly IRepository<Game> _gameRepository;
        private readonly IRepository<GameSetting> _gameSettingRepository;
        private readonly IPlayerRepository<Player> _playerRepository;
        private readonly IRepository<Team> _teamRepository;

        public GameService(IMapper mapper, IRepository<Game> gameRepository,
            IRepository<GameSetting> gameSettingRepository,
            IPlayerRepository<Player> playerRepository,
            IRepository<Team> teamRepository)
        {
            _mapper = mapper;
            _gameRepository = gameRepository ?? throw new ArgumentNullException(nameof(gameRepository));
            _gameSettingRepository = gameSettingRepository ?? throw new ArgumentNullException(nameof(gameSettingRepository));
            _playerRepository = playerRepository ?? throw new ArgumentNullException(nameof(playerRepository));
            _teamRepository = teamRepository ?? throw new ArgumentNullException(nameof(teamRepository));
        }

        public async Task<GameVM> GetByIdAsync(Guid id)
        {
            var game = await _gameRepository.GetByIdAsync(id);
            var gameVM = _mapper.Map<Game, GameVM>(game);

            var homeTeam = await _teamRepository.GetByIdAsync(gameVM.HomeTeamId);
            var homeTeamVM = _mapper.Map<Team, TeamVM>(homeTeam);
            var players = await _playerRepository.GetItemsByIdAsync(gameVM.HomeTeamId);
            homeTeamVM.Players = _mapper.Map<IEnumerable<Player>, IEnumerable<PlayerVM>>(players);
            gameVM.HomeTeam = homeTeamVM;

            var visitorTeam = await _teamRepository.GetByIdAsync(gameVM.VisitorTeamId);
            var visitorTeamVM = _mapper.Map<Team, TeamVM>(visitorTeam);
            //visitorTeamVM.Players = await _playerRepository.GetItemsByIdAsync(gameVM.VisitorTeamId);
            gameVM.VisitorTeam = visitorTeamVM;

            gameVM.GameSetting = await _gameSettingRepository.GetByIdAsync(gameVM.GameSettingId);

            return gameVM;
        }

    }
}
