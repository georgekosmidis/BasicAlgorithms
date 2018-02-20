using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using BasicAlgorithms.Trees.DataProviders.Interfaces;
using BasicAlgorithms.Trees.TreeAlgorithms;
using BasicAlgorithms.Trees.DataProviders.Models;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using BasicAlgorithms.Trees.TreeAlgorithms.TypedTrees;

namespace BasicAlgorithms.Trees
{
    public class TreeFactory
    {
        public int SampleSize { get; }
        public TreeFactory(int sample)
        {
            SampleSize = sample;
        }
        public BinaryTreeEstimation Estimate(eTreeTypes treeType)
        {
            var _tree = GetTree(treeType);
            var _treeData = new DataProvidersFactory(SampleSize).GetProvider(treeType == eTreeTypes.BST ? eTreeDataProvider.BST : eTreeDataProvider.Heap);

            return new BinaryTreeEstimation()
            {
                Deserialize = _tree.CreateTree(_treeData.Data),
                Search = _tree.Search(_treeData.Tree, _treeData.AvgValue),
                Insert = _tree.Insert(_treeData.Tree, _treeData.NotFoundValue),
            };

        }

        private ITree GetTree(eTreeTypes treeType)
        {
            switch (treeType)
            {
                case eTreeTypes.Heap:
                    return new HeapTree();
                case eTreeTypes.BST:
                    return new BinarySearchTree();
            }

            throw new NotImplementedException("Unknown tree type '" + nameof(treeType) + "'");
        }

    }
}
