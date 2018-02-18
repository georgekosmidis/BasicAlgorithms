using BasicAlgorithms.DataProviders.Interfaces;
using BasicAlgorithms.DataProviders.Models;
using BasicAlgorithms.DataProviders.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.DataProviders
{
    public class DataProvidersFactory
    {
        public int SampleSize { get; }
        public DataProvidersFactory(int sampleSize)
        {
            SampleSize = sampleSize;
        }
        public ISearchData GetProvider(eSearchDataProviders searchProvider)
        {
            switch (searchProvider)
            {
                case eSearchDataProviders.SortedAndUniform:
                    return new SortedAndUniformProvider(SampleSize);
                case eSearchDataProviders.Sorted:
                    return new SortedProvider(SampleSize);
                case eSearchDataProviders.Unsorted:
                    return new UnsortedProvider(SampleSize);
                case eSearchDataProviders.ReverseSorted:
                    return new SortedAndUniformProvider(SampleSize);
            }

            throw new NotImplementedException("Unknown data provider '" + nameof(searchProvider) + "'");
        }
    }
}
