using System.Collections.Generic;
using BasicAlgorithms.Trees.Models;

namespace BasicAlgorithms.Trees.Interfaces
{
    public interface ITree
    {
        BinaryTreeResults<BinaryTree> Delete(BinaryTree tree, int item);
        BinaryTreeResults<BinaryTree> Deserialize(List<int> data);
        BinaryTreeResults<BinaryTree> Insert(BinaryTree tree, int item);
        BinaryTreeResults<BinaryTree> Search(BinaryTree tree, int item);
        BinaryTreeResults<List<int>> Serialize(BinaryTree tree);
    }
}