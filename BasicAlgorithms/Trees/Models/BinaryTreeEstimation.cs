using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Trees.Models
{
    public class BinaryTreeEstimation
    {
        public BinaryTreeResults<BinaryTree> Deserialize { get; set; }
        public BinaryTreeResults<List<int>> Serialize { get; set; }
        public BinaryTreeResults<int> Search { get; set; }
        public BinaryTreeResults<BinaryTree> Insert { get; set; }
        public BinaryTreeResults<int> Delete { get; set; }
    }
}
