using AutoMapper;
using Timers.Client.ViewModels;
using Timers.Shared.Models;

namespace Timers.Client
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Game, GameVM>();
            CreateMap<GameVM, Game>();
            CreateMap<Team, TeamVM>();
            CreateMap<TeamVM, Team>();
            CreateMap<Player, PlayerVM>();
            CreateMap<PlayerVM, Player>();
            CreateMap<GameSetting, GameSettingVM>();
            CreateMap<GameSettingVM, GameSetting>();
        }
    }
}
