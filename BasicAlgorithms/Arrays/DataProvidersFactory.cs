using BasicAlgorithms.Arrays.DataProviders.Interfaces;
using BasicAlgorithms.Arrays.DataProviders.Models;
using BasicAlgorithms.Arrays.DataProviders.Providers;
using System;

namespace BasicAlgorithms.Arrays;

public class DataProvidersFactory
{
    public int SampleSize { get; }
    public DataProvidersFactory(int sampleSize)
    {
        SampleSize = sampleSize;
    }
    public IArrayDataProvider GetProvider(EnumArrayDataProviders arrayDataProvider)
    {
        return arrayDataProvider switch
        {
            EnumArrayDataProviders.SortedAndUniform => new SortedAndUniformProvider(SampleSize),
            EnumArrayDataProviders.Sorted => new SortedProvider(SampleSize),
            EnumArrayDataProviders.Unsorted => new UnsortedProvider(SampleSize),
            EnumArrayDataProviders.ReverseSorted => new SortedAndUniformProvider(SampleSize),
            _ => throw new NotImplementedException("Unknown data provider '" + nameof(arrayDataProvider) + "'"),
        };
    }
}
