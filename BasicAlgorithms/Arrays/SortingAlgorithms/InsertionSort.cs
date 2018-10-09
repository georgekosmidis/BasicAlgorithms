using BasicAlgorithmsArrays.SortingAlgorithms.Interfaces;
using BasicAlgorithmsArrays.SortingAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithmsArrays.SortingAlgorithms
{
    public class InsertionSort : ISort
    {

        /// <summary>
        /// Insertion Sort Algorithm [Time: O(n^2), Space: O(1)]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public SortResults Sort(List<int> data)
        {
            var results = new SortResults();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (var i = 1; i < data.Count; i++)
            {
                for (var j = i; j > 0; j--)
                {
                    if (data[j - 1] > data[j])
                    {
                        var tmp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = tmp;
                    }
                }
            }
            watch.Stop();
            results.Ticks = watch.ElapsedTicks;

            results.SortedData = data;
            return results;
        }
    }
}
