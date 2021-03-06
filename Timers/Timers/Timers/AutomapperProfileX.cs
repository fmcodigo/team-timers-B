﻿using AutoMapper;
using Timers.Shared.Models;
using Timers.VM;

namespace Timers
{
    public class AutomapperProfileX : Profile
    {
        public AutomapperProfileX()
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
