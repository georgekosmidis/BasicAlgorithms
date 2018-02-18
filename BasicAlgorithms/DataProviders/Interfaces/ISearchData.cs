using System.Collections.Generic;

namespace BasicAlgorithms.DataProviders.Interfaces
{
    public interface ISearchData
    {
        int MinValue { get; }
        int AvgValue { get; }
        int RandomValue { get; }
        int MaxValue { get; }
        int NotFoundValue { get; }
        List<int> Data { get; }
    }
}