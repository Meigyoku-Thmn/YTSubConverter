using System;
using YTSubConverter.Shared.Formats;

namespace YTSubConverter.Shared.Util
{
    public static class TimeUtil
    {
        public static DateTime Min(DateTime date1, DateTime date2)
        {
            return date1 < date2 ? date1 : date2;
        }

        public static DateTime Max(DateTime date1, DateTime date2)
        {
            return date1 > date2 ? date1 : date2;
        }

        public static int StartTimeToFrame(DateTime time, bool preferRoundUp = true)
        {
            if (time <= SubtitleDocument.TimeBase)
                return 0;

            return EndTimeToFrame(time, preferRoundUp) + 1;
        }

        public static int EndTimeToFrame(DateTime time, bool preferRoundUp = true)
        {
            if (preferRoundUp == true)
                return (int)((time.TimeOfDay.TotalMilliseconds + 1) / GlobalSettings.FrameDuration);
            return (int)(time.TimeOfDay.TotalMilliseconds / GlobalSettings.FrameDuration);
        }

        public static DateTime FrameToStartTime(int frame)
        {
            if (frame <= 0)
                return SubtitleDocument.TimeBase;

            return FrameToTime(frame).AddMilliseconds(-GlobalSettings.HalfFrameDuration);
        }

        public static DateTime FrameToEndTime(int frame)
        {
            return FrameToTime(frame).AddMilliseconds(GlobalSettings.HalfFrameDuration);
        }

        private static DateTime FrameToTime(int frame)
        {
            if (frame == 0)
                return SubtitleDocument.TimeBase;

            int ms = (int)(frame * GlobalSettings.FrameDuration);
            return SubtitleDocument.TimeBase + TimeSpan.FromMilliseconds(ms);
        }

        public static DateTime RoundTimeToFrameCenter(DateTime time, bool preferRoundUp = true)
        {
            if (time <= SubtitleDocument.TimeBase)
                return SubtitleDocument.TimeBase;

            if (GlobalSettings.DisableTimeRounding)
                return time;

            return FrameToStartTime(StartTimeToFrame(time, preferRoundUp));
        }
    }
}
