﻿using System.Collections.Generic;

namespace DynastyRazer.MangaModels.Dynasty_Scans
{
    public class DynastySerieDetails
    {
        public string Cover { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<DynastyChapter> Taggings { get; set; }
    }
}
