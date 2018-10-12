using AutoMapper;
using Timers.Shared.Models;
using Timers.Shared.ViewModels;

namespace Timers.Shared
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<IGame, IGameVM>();
            CreateMap<IGameVM, IGame>();
            CreateMap<ITeam, ITeamVM>();
            CreateMap<ITeamVM, ITeam>();
            CreateMap<IPlayer, IPlayerVM>();
            CreateMap<IPlayerVM, IPlayer>();
        }
    }
}
