using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using BasicAlgorithms.Array.DataProviders;
using BasicAlgorithms.Array.DataProviders.Models;
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
        public SortResults Estimate(eArraySortAlgorithms sortAlgorithm, eArrayDataProviders searchDataProvider)
        {
            var _sort= GetSort(sortAlgorithm);
            var _searchData = new DataProvidersFactory(SampleSize).GetProvider(searchDataProvider);

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

    }
}
