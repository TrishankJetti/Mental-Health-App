using System;
using System.Collections.Generic;

namespace MentalHealthApp.Models
{
    public class MoodEntriesViewModel
    {
        public List<MoodEntry> Entries { get; set; } = new List<MoodEntry>();

        public int CurrentStreak { get; set; }
        public int BestStreak { get; set; }
        public string Badge { get; set; } = "None";
    }
}
