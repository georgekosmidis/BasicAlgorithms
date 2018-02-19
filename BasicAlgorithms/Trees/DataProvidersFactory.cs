using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;
using BasicAlgorithms.Trees.DataProviders.Interfaces;
using BasicAlgorithms.Trees.DataProviders.Providers;
using BasicAlgorithms.Trees.SortingAlgorithms.Models;
using BasicAlgorithms.Trees.TreeAlgorithms;
using BasicAlgorithms.Trees.DataProviders.Models;

namespace BasicAlgorithms.Trees
{
    public class DataProvidersFactory
    {
        public int SampleSize { get; }
        public DataProvidersFactory(int sampleSize)
        {
            SampleSize = sampleSize;
        }

        public ITreeDataProvider GetProvider(eTreeProvider treeDataProvider)
        {
            switch (treeDataProvider)
            {
                case eTreeProvider.Heap:
                    return new TreeProvider(new HeapTree(), SampleSize);
               
            }

            throw new NotImplementedException("Unknown data provider '" + nameof(treeDataProvider) + "'");
        }
    }
}
