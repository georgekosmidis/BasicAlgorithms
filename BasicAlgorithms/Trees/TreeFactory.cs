using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using BasicAlgorithms.Trees.DataProviders.Interfaces;
using BasicAlgorithms.Trees.SortingAlgorithms.Models;
using BasicAlgorithms.Trees.TreeAlgorithms;
using BasicAlgorithms.Trees.Models;
using BasicAlgorithms.Trees.DataProviders.Models;
using BasicAlgorithms.Trees.TreeAlgorithms.Generic;

namespace BasicAlgorithms.Trees
{
    public class TreeFactory
    {
        public int SampleSize { get; }
        public TreeFactory(int sample)
        {
            SampleSize = sample;
        }
        public BinaryTreeEstimation Estimate(eTreeTypes treeType, eTreeProvider dataProvider)
        {
            var _tree = GetTree(treeType);
            var _treeData = new DataProvidersFactory(SampleSize).GetProvider(dataProvider);

            return new BinaryTreeEstimation()
            {
                Deserialize = _tree.Deserialize(_treeData.Data),
                Serialize = _tree.Serialize(_treeData.Tree),
                Search = _tree.Search(_treeData.Tree, _treeData.AvgValue),
                Delete = _tree.Delete(_treeData.Tree, _treeData.AvgValue),
                Insert = _tree.Insert(_treeData.Tree, _treeData.NotFoundValue),
            };

        }

        private ITree GetTree(eTreeTypes treeType)
        {
            switch (treeType)
            {
                case eTreeTypes.Heap:
                    return new HeapTree();
            }

            throw new NotImplementedException("Unknown tree type '" + nameof(treeType) + "'");
        }

    }
}
