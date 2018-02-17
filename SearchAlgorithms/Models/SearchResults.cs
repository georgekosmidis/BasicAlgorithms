using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms.Models
{
    public class SearchResults
    {
        public string AlgorithmName { get; set; }
        public string SearchDataName { get; set; }
        public int ArrayCount { get; set; }
        public SearchResult LeftValue { get; set; } = new SearchResult();
        public SearchResult RightValue { get; set; } = new SearchResult();
        public SearchResult MiddleValue { get; set; } = new SearchResult();
        public SearchResult RandomValue { get; set; } = new SearchResult();
        public SearchResult NotFoundValue { get; set; } = new SearchResult();
    }
}
