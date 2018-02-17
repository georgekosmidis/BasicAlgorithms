using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms.Models
{
    public class SearchResult
    {
        public int? PositionFound { get; set; }
        public long Ticks { get; set; }
        public int Cycles { get; set; }
    }
}
