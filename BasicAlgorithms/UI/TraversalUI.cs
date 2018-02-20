using BasicAlgorithms.Arrays;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using BasicAlgorithms.Array.DataProviders.Models;
using BasicAlgorithmsArrays.SortingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;
using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.DataProviders.Models;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;

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
            this.PrintLine();

            this.PrintRow("Traversal Algorithms Differences for the following tree");
            this.PrintLine();

            var traversal = _traversalFactory.Traverse(eTreeTypes.BST);

            PrintTree(traversal.Tree, "");
            this.PrintLine();

            this.PrintRow("Breadth First",
                String.Join(" ", traversal.BreadthFirstResult)
            );
            this.PrintRow("In Order",
                String.Join(" ", traversal.InOrderResult)
            );
            this.PrintRow("Post Order",
                String.Join(" ", traversal.PostOrderResult)
            );
            this.PrintRow("Pre Order",
                String.Join(" ", traversal.PreOrderResult)
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
