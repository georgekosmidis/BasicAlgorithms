using BasicAlgorithms.Arrays;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using BasicAlgorithms.Array.DataProviders.Models;
using BasicAlgorithmsArrays.SortingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;
using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.SortingAlgorithms.Models;
using BasicAlgorithms.Trees.DataProviders.Models;
using BasicAlgorithms.Trees.Models;

namespace BasicAlgorithms.UI
{
    public class TreeUI : Grid
    {

        private TreeFactory _treeFactory;
        public TreeUI(TreeFactory treeFactory, int tableWith) : base(tableWith)
        {
            _treeFactory = treeFactory;
        }

        public void Print()
        {
            this.PrintLine();

            this.PrintRow("Ticks needed for a tree of " + _treeFactory.SampleSize + " integers");
            this.PrintLine();

            this.PrintLine();
            this.PrintRow("", "Deserialize", "Serialize", "Search", "Insert", "Delete");
            this.PrintLine();

            PrintGrid("Heap",
                _treeFactory.Estimate(eTreeTypes.Heap, eTreeProvider.Heap)
            );
            
        }

        private void PrintGrid(string title, BinaryTreeEstimation r)
        {

            this.PrintRow(title,
                r.Deserialize.Ticks.ToString("00000000"),
                r.Serialize.Ticks.ToString("00000000"),
                r.Search.Ticks.ToString("00000000"),
                r.Insert.Ticks.ToString("00000000"),
                r.Delete.Ticks.ToString("00000000")
            );
            this.PrintLine();
        }
    }
}
