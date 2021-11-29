using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Trees.TreeAlgorithms.Interfaces;

public interface ITraversals
{
    BinaryTree UnTraverse(List<int> data);
    List<int> Traverse(BinaryTree tree);
}
