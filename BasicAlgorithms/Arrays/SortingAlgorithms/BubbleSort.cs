using BasicAlgorithms.Arrays.SortingAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Arrays.SortingAlgorithms;

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
                if (data[j] > data[j + 1])
                {
                    var tmp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = tmp;
                }
            }
        }

        watch.Stop();
        results.Ticks = watch.ElapsedTicks;

        results.SortedData = data;
        return results;
    }
}
