using BasicAlgorithms.Arrays;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using BasicAlgorithms.DataProviders.Models;
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
            this.PrintRow("Cycles need to search an item in " + _searchFactory.SampleSize + " integers");
            this.PrintLine();

            this.PrintLine();
            this.PrintRow("", "Linear", "Jump", "Binary", "Interpolation");
            this.PrintLine();

            this.PrintRow("Sorted, uniform distribution array");
            this.PrintLine();
            PrintGrid(
                _searchFactory.Estimate(eArraysSearchAlgorithms.Linear, eSearchDataProviders.SortedAndUniform),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Jump, eSearchDataProviders.SortedAndUniform),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Binary, eSearchDataProviders.SortedAndUniform),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Interpolation, eSearchDataProviders.SortedAndUniform)
            );

            this.PrintRow("Sorted, not evenly distributed array");
            this.PrintLine();
            PrintGrid(
                _searchFactory.Estimate(eArraysSearchAlgorithms.Linear, eSearchDataProviders.Sorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Jump, eSearchDataProviders.Sorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Binary, eSearchDataProviders.Sorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Interpolation, eSearchDataProviders.Sorted)
            );

            this.PrintRow("Unsorted (random) array");
            this.PrintLine();
            PrintGrid(
                _searchFactory.Estimate(eArraysSearchAlgorithms.Linear, eSearchDataProviders.Unsorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Jump, eSearchDataProviders.Unsorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Binary, eSearchDataProviders.Unsorted),
                _searchFactory.Estimate(eArraysSearchAlgorithms.Interpolation, eSearchDataProviders.Unsorted)
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
                (l.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MinValue.Cycles.ToString("00000000"),
                (j.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.MinValue.Cycles.ToString("00000000"),
                (b.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MinValue.Cycles.ToString("00000000"),
                (i.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.MinValue.Cycles.ToString("00000000")
            );
            this.PrintRow("Avg",
                (l.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.AvgValue.Cycles.ToString("00000000"),
                (j.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.AvgValue.Cycles.ToString("00000000"),
                (b.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.AvgValue.Cycles.ToString("00000000"),
                (i.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.AvgValue.Cycles.ToString("00000000")
            );
            this.PrintRow("Max",
                (l.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MaxValue.Cycles.ToString("00000000"),
                (j.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.MaxValue.Cycles.ToString("00000000"),
                (b.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MaxValue.Cycles.ToString("00000000"),
                (i.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.MaxValue.Cycles.ToString("00000000")
            );
            this.PrintRow("NotFound",
                (l.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.NotFoundValue.Cycles.ToString("00000000"),
                (j.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.NotFoundValue.Cycles.ToString("00000000"),
                (b.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.NotFoundValue.Cycles.ToString("00000000"),
                (i.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.NotFoundValue.Cycles.ToString("00000000")
            );
            this.PrintLine();
        }
    }
}
