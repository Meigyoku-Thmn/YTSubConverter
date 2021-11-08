using System;
using System.Collections.Generic;
using System.Text;

namespace YTSubConverter.Shared
{
    public static class GlobalSettings
    {
        public static bool DisableTimeRounding = false;

        private static decimal _fps = 30;
        public static decimal FPS {
            get => _fps;
            set {
                FrameDuration = 1000 / (double)(_fps = value);
                HalfFrameDuration = (int)(500 / (double)_fps);
            }
        }

        public static int FrameStep = 2;

        internal static double FrameDuration { get; private set; } = 33.36666666666667;
        internal static int HalfFrameDuration { get; private set; } = 16;
    }
}
