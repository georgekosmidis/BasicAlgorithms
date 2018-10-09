using BasicAlgorithms.Trees.DataProviders.Interfaces;
using BasicAlgorithms.Trees.DataProviders.Models;
using BasicAlgorithms.Trees.DataProviders.Providers;
using BasicAlgorithms.Trees.TreeAlgorithms.TypedTrees;
using System;

namespace BasicAlgorithms.Trees
{
    public class DataProvidersFactory
    {
        public int SampleSize { get; }
        public DataProvidersFactory(int sampleSize)
        {
            SampleSize = sampleSize;
        }

        public ITreeDataProvider GetProvider(eTreeDataProvider treeDataProvider)
        {
            switch (treeDataProvider)
            {
                case eTreeDataProvider.Heap:
                    return new TreeDataProvider(new HeapTree(), SampleSize);
                case eTreeDataProvider.BST:
                    return new TreeDataProvider(new BinarySearchTree(), SampleSize);
            }

            throw new NotImplementedException("Unknown data provider '" + nameof(treeDataProvider) + "'");
        }
    }
}
