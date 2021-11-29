using System.Collections.Generic;

namespace BasicAlgorithms.Arrays.DataProviders.Interfaces;

public interface IArrayDataProvider
{
    int MinValue { get; }
    int AvgValue { get; }
    int RandomValue { get; }
    int MaxValue { get; }
    int NotFoundValue { get; }
    List<int> Data { get; }
}
