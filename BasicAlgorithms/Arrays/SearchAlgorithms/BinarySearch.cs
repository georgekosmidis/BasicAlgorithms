using BasicAlgorithms.Arrays.SearchAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Arrays.SearchAlgorithms
{
    public class BinarySearch : ISearch
    {
        /// <summary>
        /// Binary Search  [Time: O(log(n)), Space: O(1)]
        /// </summary>
        /// <param name="data">The array to search</param>
        /// <param name="value">The value to search</param>
        /// <returns>SearchResult object with statistics</returns>
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
