using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using System;

namespace BasicAlgorithms.UI
{
    public class TraversalUI : Grid
    {

        private TraversalFactory _traversalFactory;
        public TraversalUI(TraversalFactory traversalFactory, int tableWith) : base(tableWith)
        {
            _traversalFactory = traversalFactory;
        }

        public void Print()
        {
            PrintLine();

            PrintRow("Traversal Algorithms Differences for the following tree");
            PrintLine();

            var traversal = _traversalFactory.Traverse(eTreeTypes.BST);

            PrintTree(traversal.Tree, "");
            PrintLine();

            PrintRow("Breadth First",
                string.Join(" ", traversal.BreadthFirstResult)
            );
            PrintRow("In Order",
                string.Join(" ", traversal.InOrderResult)
            );
            PrintRow("Post Order",
                string.Join(" ", traversal.PostOrderResult)
            );
            PrintRow("Pre Order",
                string.Join(" ", traversal.PreOrderResult)
            );
        }

        public void PrintTree(BinaryTree tree, string indent)
        {
            Console.Write(indent);
            Console.Write("^-");
            indent += "   ";

            if (tree == null)
            {
                Console.WriteLine("[ ]");
                return;
            }
            else
                Console.WriteLine("[" + tree.Data + "]");

            if (tree.LeftNode != null || tree.RightNode != null)
            {
                PrintTree(tree.LeftNode, indent);
                PrintTree(tree.RightNode, indent);
            }

        }
    }
}
