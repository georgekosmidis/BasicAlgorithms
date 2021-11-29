using BasicAlgorithms.Arrays.DataProviders.Models;
using BasicAlgorithms.Arrays.SortingAlgorithms;
using BasicAlgorithms.Arrays.SortingAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using System;

namespace BasicAlgorithms.Arrays;

public class ArraySortFactory
{
    public int SampleSize { get; }

    public ArraySortFactory(int sample)
    {
        SampleSize = sample;
    }

    public SortResults Estimate(EnumArraySortAlgorithms sortAlgorithm, EnumArrayDataProviders searchDataProvider)
    {
        var _sort = GetSort(sortAlgorithm);
        var _searchData = new DataProvidersFactory(SampleSize).GetProvider(searchDataProvider);

        return _sort.Sort(_searchData.Data);
    }

    private static ISort GetSort(EnumArraySortAlgorithms sortAlgorithm)
    {
        return sortAlgorithm switch
        {
            EnumArraySortAlgorithms.Insertion => new InsertionSort(),
            EnumArraySortAlgorithms.Selection => new SelectionSort(),
            EnumArraySortAlgorithms.Bubble => new BubbleSort(),
            EnumArraySortAlgorithms.Heap => new HeapSort(),
            EnumArraySortAlgorithms.Merge => new MergeSort(),
            EnumArraySortAlgorithms.Quick => new QuickSort(),
            _ => throw new NotImplementedException("Unknown algorithm '" + nameof(sortAlgorithm) + "'"),
        };
    }
}
