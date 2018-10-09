using BasicAlgorithms.Arrays.SearchAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using System;
using System.Collections.Generic;

namespace BasicAlgorithms.Arrays.SearchAlgorithms
{
    public class JumpSearch : ISearch
    {
        /// <summary>
        /// Jump Search [Time: O(sqrt(n)), Space: O(sqrt(n))]
        /// </summary>
        /// <param name="data">The array to search</param>
        /// <param name="value">The value to search</param>
        /// <returns>SearchResult object with statistics</returns>
        public SearchResult Find(List<int> data, int value)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var searchResult = new SearchResult();

            var length = data.Count;
            //first find block
            int blockSize = Convert.ToInt32(Math.Sqrt(length));
            int block = 0;
            while (block < length / blockSize)
            {
                var blockUpperLimit = Math.Min((1 + block) * blockSize, length - 1);
                if (value <= data[blockUpperLimit])//we ve jsut passed it
                    break;
                block++;
            }

            //then find block
            for (var i = block * blockSize; i < length; i++)
            {
                if (value == data[i])
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
