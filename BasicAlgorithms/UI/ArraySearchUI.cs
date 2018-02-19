using BasicAlgorithms.Arrays;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using BasicAlgorithms.Array.DataProviders.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.UI
{
    public class ArraySearchUI : Grid
    {

        private ArraySearchFactory _searchFactory;
        public ArraySearchUI(ArraySearchFactory searchFactory, int tableWith) : base(tableWith)
        {
            _searchFactory = searchFactory;
        }

        public void Print()
        {
            this.PrintLine();
            this.PrintRow("Ticks needed to search an item in " + _searchFactory.SampleSize + " integers");
            this.PrintLine();

            this.PrintLine();
            this.PrintRow("", "Linear", "Jump", "Binary", "Interpolation");
            this.PrintLine();

            this.PrintRow("Sorted, uniform distribution array");
            this.PrintLine();
            PrintGrid(
                _searchFactory.Estimate(eArraysSearchAlgorithms.Linear, eArrayDataProviders.SortedAndUniform),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Jump, eArrayDataProviders.SortedAndUniform),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Binary, eArrayDataProviders.SortedAndUniform),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Interpolation, eArrayDataProviders.SortedAndUniform)
            );

            this.PrintRow("Sorted, not evenly distributed array");
            this.PrintLine();
            PrintGrid(
                _searchFactory.Estimate(eArraysSearchAlgorithms.Linear, eArrayDataProviders.Sorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Jump, eArrayDataProviders.Sorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Binary, eArrayDataProviders.Sorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Interpolation, eArrayDataProviders.Sorted)
            );

            this.PrintRow("Unsorted (random) array");
            this.PrintLine();
            PrintGrid(
                _searchFactory.Estimate(eArraysSearchAlgorithms.Linear, eArrayDataProviders.Unsorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Jump, eArrayDataProviders.Unsorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Binary, eArrayDataProviders.Unsorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Interpolation, eArrayDataProviders.Unsorted)
            );

            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Target found, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Target not found!");
            Console.WriteLine();
            Console.ForegroundColor = color;
        }

        private void PrintGrid(SearchResults l, SearchResults j, SearchResults b, SearchResults i)
        {

            this.PrintRow("Min",
                (l.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MinValue.Ticks.ToString("00000000"),
                (j.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.MinValue.Ticks.ToString("00000000"),
                (b.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MinValue.Ticks.ToString("00000000"),
                (i.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.MinValue.Ticks.ToString("00000000")
            );
            this.PrintRow("Avg",
                (l.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.AvgValue.Ticks.ToString("00000000"),
                (j.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.AvgValue.Ticks.ToString("00000000"),
                (b.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.AvgValue.Ticks.ToString("00000000"),
                (i.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.AvgValue.Ticks.ToString("00000000")
            );
            this.PrintRow("Max",
                (l.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MaxValue.Ticks.ToString("00000000"),
                (j.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.MaxValue.Ticks.ToString("00000000"),
                (b.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MaxValue.Ticks.ToString("00000000"),
                (i.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.MaxValue.Ticks.ToString("00000000")
            );
            this.PrintRow("NotFound",
                (l.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.NotFoundValue.Ticks.ToString("00000000"),
                (j.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.NotFoundValue.Ticks.ToString("00000000"),
                (b.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.NotFoundValue.Ticks.ToString("00000000"),
                (i.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.NotFoundValue.Ticks.ToString("00000000")
            );
            this.PrintLine();
        }
    }
}
