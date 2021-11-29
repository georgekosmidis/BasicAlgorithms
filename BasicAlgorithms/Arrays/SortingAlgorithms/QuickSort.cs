using BasicAlgorithms.Arrays.SortingAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Arrays.SortingAlgorithms;

public class QuickSort : ISort
{

    /// <summary>
    /// Quick Sort Algorithm [Time: O(n*logn), Space: O(n)]
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public SortResults Sort(List<int> data)
    {
        var results = new SortResults();
        var watch = System.Diagnostics.Stopwatch.StartNew();

        HelperSort(data, 0, data.Count - 1);

        watch.Stop();
        results.Ticks = watch.ElapsedTicks;

        results.SortedData = data;
        return results;
    }

    private void HelperSort(List<int> data, int start, int end)
    {
        if (start < end)
        {
            var middle = HelperPartition(data, start, end);
            HelperSort(data, start, middle - 1);
            HelperSort(data, middle + 1, end);
        }
    }

    private static int HelperPartition(List<int> data, int start, int end)
    {
        //loop partition and swap with last of partition (last as pivot)
        for (var i = start; i < end; i++)
        {
            if (data[i] <= data[end])
            {
                var tmp = data[start];
                data[start] = data[i];
                data[i] = tmp;
                start++;//move new pivot
            }
        }

        //replace new pivot item with last
        var tmp2 = data[start];
        data[start] = data[end];
        data[end] = tmp2;

        return start;
    }
}
