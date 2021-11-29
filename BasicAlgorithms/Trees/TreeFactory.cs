using BasicAlgorithms.Trees.DataProviders.Models;
using BasicAlgorithms.Trees.TreeAlgorithms.Interfaces;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using BasicAlgorithms.Trees.TreeAlgorithms.TypedTrees;
using System;

namespace BasicAlgorithms.Trees;

public class TreeFactory
{
    public int SampleSize { get; }
    public TreeFactory(int sample)
    {
        SampleSize = sample;
    }

    public BinaryTreeEstimation Estimate(EnumTreeTypes treeType)
    {
        var _tree = GetTree(treeType);
        var _treeData = new DataProvidersFactory(SampleSize).GetProvider(treeType == EnumTreeTypes.BST ? EnumTreeDataProvider.BST : EnumTreeDataProvider.Heap);

        return new BinaryTreeEstimation()
        {
            Deserialize = _tree.CreateTree(_treeData.Data),
            Search = _tree.Search(_treeData.Tree, _treeData.AvgValue),
            Insert = _tree.Insert(_treeData.Tree, _treeData.NotFoundValue),
        };

    }

    private static ITree GetTree(EnumTreeTypes treeType)
    {
        return treeType switch
        {
            EnumTreeTypes.Heap => new HeapTree(),
            EnumTreeTypes.BST => new BinarySearchTree(),
            _ => throw new NotImplementedException("Unknown tree type '" + nameof(treeType) + "'"),
        };
    }
}
