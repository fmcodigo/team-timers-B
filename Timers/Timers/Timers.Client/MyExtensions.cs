using System;

namespace Timers.Client
{
    public static class MyExtensions
    {
        public static string ToTextOnOff(this bool b)
        {
            return (b) ? "On" : "Off";
        }

        public static string ToTextEditOnOff(this bool b)
        {
            return (b) ? "Edit On" : "Edit Off";
        }

        //public static string ToIconCheck(this bool b)
        //{
        //    return (b) ? "oi oi-check" : "oi oi-grid-four-up";
        //}

        //public static string ToTextBtnPrimary(this bool b)
        //{
        //    return (b) ? "btn btn-primary active" : "btn btn-secondary";
        //}

        public static string ToTextBtnPrimaryBlock(this bool b)
        {
            return (b) ? "btn btn-primary btn-block active" : "btn btn-secondary btn-block";
        }

        public static string ToTextListGroupItemPrimary(this bool b)
        {
            return (b) ? "list-group-item-primary" : "";
        }

        public static string ToTimerString(this int seconds)
        {
            return DateTime.ParseExact("00:00:00", "HH:mm:ss", null).AddSeconds(seconds).ToString("HH:mm:ss");
        }

        public static string ToProgressBarStyleWidth(this double i)
        {
            var result = (int)i;
            return $"width: {result.ToString()}%";
        }
    }
}
