using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Trees.DataProviders.Interfaces
{
    public interface ITreeDataProvider
    {
        int AvgValue { get; }
        int MaxValue { get; }
        int MinValue { get; }
        int NotFoundValue { get; }
        int RandomValue { get; }
        List<int> Data { get; }
        BinaryTree Tree { get; }
    }
}