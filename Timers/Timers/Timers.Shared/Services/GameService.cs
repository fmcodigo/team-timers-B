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

        private readonly IRepository<IGame> _gameRepository;
        private readonly IRepository<IGameSetting> _gameSettingRepository;
        private readonly IPlayerRepository<IPlayer> _playerRepository;
        private readonly IRepository<ITeam> _teamRepository;

        public GameService(IMapper mapper, IRepository<IGame> gameRepository,
            IRepository<IGameSetting> gameSettingRepository,
            IPlayerRepository<IPlayer> playerRepository,
            IRepository<ITeam> teamRepository)
        {
            _mapper = mapper;
            _gameRepository = gameRepository ?? throw new ArgumentNullException(nameof(gameRepository));
            _gameSettingRepository = gameSettingRepository ?? throw new ArgumentNullException(nameof(gameSettingRepository));
            _playerRepository = playerRepository ?? throw new ArgumentNullException(nameof(playerRepository));
            _teamRepository = teamRepository ?? throw new ArgumentNullException(nameof(teamRepository));
        }

        public async Task<IGameVM> GetByIdAsync(Guid id)
        {
            var game = await _gameRepository.GetByIdAsync(id);
            var gameVM = _mapper.Map<IGame, IGameVM>(game);

            var homeTeam = await _teamRepository.GetByIdAsync(gameVM.HomeTeamId);
            var homeTeamVM = _mapper.Map<ITeam, ITeamVM>(homeTeam);
            var players = await _playerRepository.GetItemsByIdAsync(gameVM.HomeTeamId);
            homeTeamVM.Players = _mapper.Map<IEnumerable<IPlayer>, IEnumerable<IPlayerVM>>(players);
            gameVM.HomeTeam = homeTeamVM;

            var visitorTeam = await _teamRepository.GetByIdAsync(gameVM.VisitorTeamId);
            var visitorTeamVM = _mapper.Map<ITeam, ITeamVM>(visitorTeam);
            gameVM.VisitorTeam = visitorTeamVM;

            gameVM.GameSetting = await _gameSettingRepository.GetByIdAsync(gameVM.GameSettingId);

            return gameVM;
        }

    }
}
