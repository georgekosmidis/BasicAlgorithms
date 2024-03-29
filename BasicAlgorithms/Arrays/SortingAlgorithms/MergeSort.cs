﻿using BasicAlgorithms.Arrays.SortingAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Arrays.SortingAlgorithms;

public class MergeSort : ISort
{

    /// <summary>
    /// Merge Sort Algorithm [Time: O(n*logn), Space: O(n)]
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
            var middle = (start + end) / 2;
            HelperSort(data, start, middle);
            HelperSort(data, middle + 1, end);
            HelperMerge(data, start, middle, end);
        }
    }

    private static void HelperMerge(List<int> data, int start, int middle, int end)
    {
        //create the two arrays to merge
        var a1 = new List<int>();
        var a2 = new List<int>();
        for (var i = start; i <= middle; i++)
        {
            a1.Add(data[i]);
        }
        for (var i = middle + 1; i <= end; i++)
        {
            a2.Add(data[i]);
        }

        //loop through both arrays and check order
        var i1 = 0;
        var i2 = 0;
        var iData = start;
        while (i1 < a1.Count && i2 < a2.Count)
        {
            if (a1[i1] <= a2[i2])
            {
                data[iData] = a1[i1];
                i1++;
            }
            else
            {
                data[iData] = a2[i2];
                i2++;
            }
            iData++;
        }

        //add any item that left out
        while (i1 < a1.Count)
        {
            data[iData++] = a1[i1++];
        }

        while (i2 < a2.Count)
        {
            data[iData++] = a2[i2++];
        }
    }
}
