using BasicAlgorithmsArrays.SortingAlgorithms.Interfaces;
using BasicAlgorithmsArrays.SortingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmsArrays.SortingAlgorithms
{
    public class BubbleSort : ISort
    {

        /// <summary>
        /// Bubble Sort Algorithm [Time: O(n^2), Space: O(1)]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public SortResults Sort(List<int> data)
        {
            var results = new SortResults();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (var i = 0; i < data.Count; i++)
            {
                for (var j = 0; j < data.Count - 1; j++)
                {
                    results.Cycles++;
                    if (data[j] > data[j + 1])
                    {
                        var tmp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tmp;
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
