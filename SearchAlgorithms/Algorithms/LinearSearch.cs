using SearchAlgorithms.Interfaces;
using SearchAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms.Algorithms
{
    public class LinearSearch : ISearch
    {
        public string Name { get; } = "Linear Search [Time: O(n), Space: O(1)]";


        public SearchResult Find(List<int> data, int value)
        {
            var searchResult = new SearchResult();
            var watch = System.Diagnostics.Stopwatch.StartNew();
   

            for (var i = 0; i < data.Count; i++)
            {
                searchResult.Cycles++;
                if (data[i] == value)
                {
                    searchResult.PositionFound = i;
                    break;
                }
            }

            watch.Stop();
            searchResult.Ticks = watch.ElapsedMilliseconds;
            return searchResult;
        }
    }
}
