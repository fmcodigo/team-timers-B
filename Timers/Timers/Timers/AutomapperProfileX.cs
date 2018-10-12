using AutoMapper;
using Timers.Models;
using Timers.Shared.Models;
using Timers.Shared.ViewModels;

namespace Timers
{
    public class AutomapperProfileX : Profile
    {
        public AutomapperProfileX()
        {
            CreateMap<IGame, GameXVM>();
            CreateMap<GameXVM, IGame>();
            CreateMap<ITeam, TeamXVM>();
            CreateMap<TeamXVM, ITeam>();
            CreateMap<IPlayer, PlayerXVM>();
            CreateMap<PlayerXVM, IPlayer>();
        }
    }
}
