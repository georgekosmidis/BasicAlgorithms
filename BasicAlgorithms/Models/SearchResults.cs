using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Models
{
    public class SearchResults
    {
        public int ArrayCount { get; set; }
        public SearchResult LeftValue { get; set; } = new SearchResult();
        public SearchResult RightValue { get; set; } = new SearchResult();
        public SearchResult MiddleValue { get; set; } = new SearchResult();
        public SearchResult RandomValue { get; set; } = new SearchResult();
        public SearchResult NotFoundValue { get; set; } = new SearchResult();
    }
}
