using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using BasicAlgorithms.Array.DataProviders.Interfaces;
using BasicAlgorithms.Array.DataProviders.Models;
using BasicAlgorithms.Array.DataProviders.Providers;
using BasicAlgorithms.Trees;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Arrays
{
    public class DataProvidersFactory
    {
        public int SampleSize { get; }
        public DataProvidersFactory(int sampleSize)
        {
            SampleSize = sampleSize;
        }
        public IArrayDataProvider GetProvider(eArrayDataProviders arrayDataProvider)
        {
            switch (arrayDataProvider)
            {
                case eArrayDataProviders.SortedAndUniform:
                    return new SortedAndUniformProvider(SampleSize);
                case eArrayDataProviders.Sorted:
                    return new SortedProvider(SampleSize);
                case eArrayDataProviders.Unsorted:
                    return new UnsortedProvider(SampleSize);
                case eArrayDataProviders.ReverseSorted:
                    return new SortedAndUniformProvider(SampleSize);
            }

            throw new NotImplementedException("Unknown data provider '" + nameof(arrayDataProvider) + "'");
        }
    }
}
