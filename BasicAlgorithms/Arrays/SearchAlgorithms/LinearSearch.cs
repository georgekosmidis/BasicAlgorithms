using BasicAlgorithms.Arrays.SearchAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Arrays.SearchAlgorithms
{
    public class LinearSearch : ISearch
    {
        /// <summary>
        /// Linear Search [Time: O(n), Space: O(1)]
        /// </summary>
        /// <param name="data">The array to search</param>
        /// <param name="value">The value to search</param>
        /// <returns>SearchResult object with statistics</returns>
        public SearchResult Find(List<int> data, int value)
        {
            var searchResult = new SearchResult();
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (var i = 0; i < data.Count; i++)
            {
                if (data[i] == value)
                {
                    searchResult.PositionFound = i;
                    break;
                }
            }

            watch.Stop();
            searchResult.Ticks = watch.ElapsedTicks;
            return searchResult;
        }
    }
}
