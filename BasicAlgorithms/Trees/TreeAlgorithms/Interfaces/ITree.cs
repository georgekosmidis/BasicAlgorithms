using System.Collections.Generic;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;

namespace BasicAlgorithms.Trees.Interfaces
{
    public interface ITree
    {
        BinaryTreeResults<BinaryTree> CreateTree(List<int> data);
        BinaryTreeResults<BinaryTree> Insert(BinaryTree tree, int item);
        BinaryTreeResults<BinaryTree> Search(BinaryTree tree, int item);
    }
}