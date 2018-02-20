using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Trees.TreeAlgorithms.Models
{
    public class TraversalResults
    {
        public List<int> BreadthFirstResult { get; set; }
        public List<int> InOrderResult { get; set; }
        public List<int> PostOrderResult { get; set; }
        public List<int> PreOrderResult { get; set; }
        public BinaryTree Tree { get; set; }
    }
}
