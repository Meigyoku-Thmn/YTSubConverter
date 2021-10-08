﻿using System.Collections.Generic;

namespace Arc.YTSubConverter.Shared.Formats.Ass
{
    internal class AssTagContext
    {
        public delegate List<AssLine> PostProcessor();

        public AssDocument Document;
        public AssStyle InitialStyle;
        public AssStyleOptions InitialStyleOptions;
        public AssStyle Style;
        public AssStyleOptions StyleOptions;
        public AssLine Line;
        public AssSection Section;
        public readonly List<PostProcessor> PostProcessors = new List<PostProcessor>();
    }
}
