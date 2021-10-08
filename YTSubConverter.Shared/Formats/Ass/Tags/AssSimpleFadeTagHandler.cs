﻿using System;
using System.Collections.Generic;
using YTSubConverter.Shared.Animations;

namespace YTSubConverter.Shared.Formats.Ass.Tags
{
    internal class AssSimpleFadeTagHandler : AssTagHandlerBase
    {
        public override string Tag => "fad";

        public override bool AffectsWholeLine => true;

        public override void Handle(AssTagContext context, string arg)
        {
            List<float> times = ParseFloatList(arg);
            if (times == null || times.Count != 2)
                return;

            AssLine line = context.Line;
            DateTime fadeInStartTime = line.Start;
            DateTime fadeInEndTime = line.Start.AddMilliseconds(times[0]);
            DateTime fadeOutStartTime = line.End.AddMilliseconds(-times[1]);
            DateTime fadeOutEndTime = line.End;

            if (fadeInEndTime > fadeInStartTime)
                line.Animations.Add(new FadeAnimation(fadeInStartTime, 0, fadeInEndTime, 255));

            if (fadeOutEndTime > fadeOutStartTime)
                line.Animations.Add(new FadeAnimation(fadeOutStartTime, 255, fadeOutEndTime, 0));
        }
    }
}
