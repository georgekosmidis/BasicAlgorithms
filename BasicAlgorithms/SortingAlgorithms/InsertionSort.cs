using BasicAlgorithms.SortingAlgorithms.Interfaces;
using BasicAlgorithms.SortingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.SortingAlgorithms
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
                    results.Cycles++;
                    if (data[j - 1] > data[j])
                    {
                        var tmp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = tmp;
                    }
                }
            }
            results.SortedData = data;
            watch.Stop();
            results.Ticks = watch.ElapsedMilliseconds;
            return results;
        }
    }
}
