using BasicAlgorithms.SortingAlgorithms.Interfaces;
using BasicAlgorithms.SortingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.SortingAlgorithms
{
    public class SelectionSort : ISort
    {

        /// <summary>
        /// Selection Sort Algorithm [Time: O(n^2), Space: O(1)]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public SortResults Sort(List<int> data)
        {
            var results = new SortResults();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (var i = 0; i < data.Count - 1; i++)
            {
                var min = i;
                for (var j = i + 1; j < data.Count; j++)
                {
                    results.Cycles++;
                    if (data[j] < data[min])
                        min = j;
                }
                if (min != i)
                {
                    var tmp = data[min];
                    data[min] = data[i];
                    data[i] = tmp;
                }
            }
            results.SortedData = data;
            watch.Stop();
            results.Ticks = watch.ElapsedMilliseconds;
            return results;
        }
    }
}
