using BasicAlgorithms.Trees.DataProviders.Interfaces;
using BasicAlgorithms.Trees.DataProviders.Models;
using BasicAlgorithms.Trees.DataProviders.Providers;
using BasicAlgorithms.Trees.TreeAlgorithms.TypedTrees;
using System;

namespace BasicAlgorithms.Trees;

public class DataProvidersFactory
{
    public int SampleSize { get; }
    public DataProvidersFactory(int sampleSize)
    {
        SampleSize = sampleSize;
    }

    public ITreeDataProvider GetProvider(EnumTreeDataProvider treeDataProvider)
    {
        return treeDataProvider switch
        {
            EnumTreeDataProvider.Heap => new TreeDataProvider(new HeapTree(), SampleSize),
            EnumTreeDataProvider.BST => new TreeDataProvider(new BinarySearchTree(), SampleSize),
            _ => throw new NotImplementedException("Unknown data provider '" + nameof(treeDataProvider) + "'"),
        };
    }
}
