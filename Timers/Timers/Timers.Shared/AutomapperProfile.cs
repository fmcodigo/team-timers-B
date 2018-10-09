using AutoMapper;
using Timers.Shared.Models;
using Timers.Shared.ViewModels;

namespace Timers.Shared
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
        }
    }
}
