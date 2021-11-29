using BasicAlgorithms.Arrays.SearchAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Arrays.SearchAlgorithms;

public class InterpolationSearch : ISearch
{
    /// <summary>
    /// Interpolation Search  [Time: O(log(log(n))), Space: O(1)]
    /// </summary>
    /// <param name="data">The array to search</param>
    /// <param name="value">The value to search</param>
    /// <returns>SearchResult object with statistics</returns>
    public SearchResult Find(List<int> data, int value)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        var searchResult = new SearchResult();

        var start = 0;
        var end = data.Count - 1;
        int pos = -1;
        while (start <= end)
        {
            pos = (int)(start + (((double)(end - start) / (data[end] - data[start])) * (value - data[start])));
            if (pos < 0 || pos > data.Count - 1)
            {
                pos = -1;
                break;
            }

            if (data[pos] == value)
            {
                break;
            }

            if (value > data[pos])
            {
                start = pos + 1;
            }
            else
            {
                end = pos - 1;
            }
        }

        watch.Stop();
        searchResult.Ticks = watch.ElapsedTicks;

        if (pos >= 0 && data[pos] == value)
        {
            searchResult.PositionFound = pos;
        }

        return searchResult;
    }
}
