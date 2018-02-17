using System.Collections.Generic;

namespace SearchAlgorithms.Interfaces
{
    public interface ISearchData
    {
        int MinValue { get; }
        int AvgValue { get; }
        int RandomValue { get; }
        int MaxValue { get; }
        int NotFoundValue { get; }
        List<int> Data { get; }
        string Name { get; }
    }
}