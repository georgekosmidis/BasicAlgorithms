using BasicAlgorithms.Trees.DataProviders.Interfaces;
using BasicAlgorithms.Trees.DataProviders.Models;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using BasicAlgorithms.Trees.TreeAlgorithms.Traversals;
using System;

namespace BasicAlgorithms.Trees
{
    public class TraversalFactory
    {
        public int SampleSize { get; }
        public TraversalFactory(int sample)
        {
            SampleSize = sample;
        }

        public TraversalResults Traverse(eTreeTypes treeType)
        {
            //var _tree = GetTree(treeType);
            var treeData = GetTreeData(treeType);

            return new TraversalResults()
            {
                Tree = treeData.Tree,
                BreadthFirstResult = new BreadthFirstTraversal().Traverse(treeData.Tree),
                InOrderResult = new InOrderTraversal().Traverse(treeData.Tree),
                PostOrderResult = new PostOrderTraversal().Traverse(treeData.Tree),
                PreOrderResult = new PreOrderTraversal().Traverse(treeData.Tree),
            };
        }

        private ITreeDataProvider GetTreeData(eTreeTypes treeType)
        {
            switch (treeType)
            {
                case eTreeTypes.Heap:
                    return new DataProvidersFactory(SampleSize).GetProvider(eTreeDataProvider.Heap);
                case eTreeTypes.BST:
                    return new DataProvidersFactory(SampleSize).GetProvider(eTreeDataProvider.BST);
            }

            throw new NotImplementedException("Unknown tree type '" + nameof(treeType) + "'");
        }

    }
}
