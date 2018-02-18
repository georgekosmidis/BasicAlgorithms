using BasicAlgorithms.Arrays.SearchAlgorithms;
using BasicAlgorithms.Arrays.SearchAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using BasicAlgorithms.DataProviders;
using BasicAlgorithms.DataProviders.Interfaces;
using BasicAlgorithms.DataProviders.Models;
using BasicAlgorithmsArrays.SortingAlgorithms;
using BasicAlgorithmsArrays.SortingAlgorithms.Interfaces;
using BasicAlgorithmsArrays.SortingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Arrays
{
    public class ArraySortFactory
    {
        public int SampleSize { get; }
        public ArraySortFactory(int sample)
        {
            SampleSize = sample;
        }
        public SortResults Estimate(eArraySortAlgorithms sortAlgorithm, eSearchDataProviders searchDataProvider)
        {
            var _sort= GetSort(sortAlgorithm);
            var _searchData = GetSearchData(searchDataProvider);

            return _sort.Sort(_searchData.Data);

        }

        private ISort GetSort(eArraySortAlgorithms sortAlgorithm)
        {
            switch (sortAlgorithm)
            {
                case eArraySortAlgorithms.Insertion:
                    return new InsertionSort();
                case eArraySortAlgorithms.Selection:
                    return new SelectionSort();
                case eArraySortAlgorithms.Bubble:
                    return new BubbleSort();
                case eArraySortAlgorithms.Heap:
                    return new HeapSort();
                case eArraySortAlgorithms.Merge:
                    return new MergeSort();
                case eArraySortAlgorithms.Quick:
                    return new QuickSort();
            }

            throw new NotImplementedException("Unknown algorithm '" + nameof(sortAlgorithm) + "'");
        }

        private ISearchData GetSearchData(eSearchDataProviders searchData)
        {
            switch (searchData)
            {
                case eSearchDataProviders.ReverseSorted:
                    return new SortedAndUniformProvider(SampleSize);
                case eSearchDataProviders.Sorted:
                    return new SortedProvider(SampleSize);
                case eSearchDataProviders.Unsorted:
                    return new UnsortedProvider(SampleSize);
            }

            throw new NotImplementedException("Unknown data provider '" + nameof(searchData) + "'");
        }
    }
}
