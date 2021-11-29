using BasicAlgorithms.Arrays.SortingAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Arrays.SortingAlgorithms;

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
            var max = i;
            for (var j = i + 1; j < data.Count; j++)
            {
                if (data[j] < data[max])
                {
                    max = j;
                }
            }
            if (max != i)
            {
                var tmp = data[max];
                data[max] = data[i];
                data[i] = tmp;
            }
        }

        watch.Stop();
        results.Ticks = watch.ElapsedTicks;

        results.SortedData = data;
        return results;
    }
}
