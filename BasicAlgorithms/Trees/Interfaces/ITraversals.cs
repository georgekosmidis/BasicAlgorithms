using System.Collections.Generic;
using BasicAlgorithms.Trees.Models;

namespace BasicAlgorithms.Trees.Interfaces
{
    public interface ITraversals
    {
        BinaryTree UnTraverse(List<int> data);
        List<int> Traverse(BinaryTree tree);
    }
}