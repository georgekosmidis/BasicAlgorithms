using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;
using BasicAlgorithms.Trees.DataProviders.Interfaces;
using BasicAlgorithms.Trees.DataProviders.Providers;
using BasicAlgorithms.Trees.TreeAlgorithms;
using BasicAlgorithms.Trees.DataProviders.Models;
using BasicAlgorithms.Trees.TreeAlgorithms.TypedTrees;

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
