using System.Collections.Generic;
using BasicAlgorithms.Trees.Models;

namespace BasicAlgorithms.Trees.Interfaces
{
    public interface ITraversals
    {
        BinaryTree FirstFree(BinaryTree tree);
        List<int> Traverse(BinaryTree tree);
    }
}