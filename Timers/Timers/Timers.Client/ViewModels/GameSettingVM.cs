using Timers.Shared.Models;
using Timers.Shared.ViewModels;

namespace Timers.Client.ViewModels
{
    public class GameSettingVM : GameSetting, IGameSettingVM
    {
        public int MaxPlayerSeconds => (MinutesPerPeriod * Periods * 60);
    }
}
