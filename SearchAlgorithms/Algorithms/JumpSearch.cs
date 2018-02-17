using SearchAlgorithms.Interfaces;
using SearchAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms.Algorithms
{
    public class JumpSearch : ISearch
    {
        public string Name { get; } = "Jump Search [Time: O(sqrt(n)), Space: O(1)]";

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
                var blockUpperLimit = Math.Min((1 + block) * blockSize, length-1);
                if (value <= data[blockUpperLimit])//we ve jsut passed it
                    break;
                block++;
            }

            //then find block
            for (var i = block * blockSize; i < length; i++)
            {
                searchResult.Cycles++;
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
