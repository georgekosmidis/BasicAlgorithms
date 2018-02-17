using SearchAlgorithms.Interfaces;
using SearchAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms.Algorithms
{
    public class BinarySearch : ISearch
    {
        public string Name { get; } = "BinarySearch  [Time: O(log(n)), Space: O(1)]";

        public SearchResult Find(List<int> data, int value)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var searchResult = new SearchResult();

            var start = 0;
            var end = data.Count - 1;
            var middle = (end - start) / 2;//floor

            while (start < end)
            {
                searchResult.Cycles++;
               
                if (data[middle] == value)
                    break;

                if (value > data[middle])
                    start = middle + 1;
                else
                    end = middle - 1;

                middle = start + ((end - start) / 2);
            }

            if (data[middle] == value)
            {
                watch.Stop();
                searchResult.PositionFound = middle;
                searchResult.Ticks = watch.ElapsedTicks;
            }

            return searchResult;
        }
    }
}
