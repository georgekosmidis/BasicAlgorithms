using BasicAlgorithms.ArraySearchAlgorithms;
using BasicAlgorithms.ArraySearchAlgorithms.Models;
using BasicAlgorithms.DataProviders;
using BasicAlgorithms.DataProviders.Models;
using BasicAlgorithms.UI;
using System;
using System.Collections.Generic;

namespace BasicAlgorithms
{
    class Program
    {
        static Grid grid = new Grid(90);
        static int sample = 1000000;
        static void Main(string[] args)
        {
            grid.PrintLine();
            grid.PrintRow("", "Linear", "Jump", "Binary", "Interpolation");
            grid.PrintLine();

            grid.PrintRow("Sorted, uniform distribution array of " + sample + " integers");
            grid.PrintLine();
            PrintGrid(
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Linear, eSearchDataProviders.SortedAndUniform),
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Jump, eSearchDataProviders.SortedAndUniform),
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Binary, eSearchDataProviders.SortedAndUniform),
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Interpolation, eSearchDataProviders.SortedAndUniform)
            );

            grid.PrintRow("Sorted, not evenly distributed array of " + sample + " integers");
            grid.PrintLine();
            PrintGrid(
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Linear, eSearchDataProviders.Sorted),
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Jump, eSearchDataProviders.Sorted),
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Binary, eSearchDataProviders.Sorted),
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Interpolation, eSearchDataProviders.Sorted)
            );

            grid.PrintRow("Unsorted (random) array of " + sample + " integers");
            grid.PrintLine();
            PrintGrid(
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Linear, eSearchDataProviders.Unsorted),
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Jump, eSearchDataProviders.Unsorted),
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Binary, eSearchDataProviders.Unsorted),
                new ArraySearchFactory(sample).Estimate(eArraySearchAlgorithms.Interpolation, eSearchDataProviders.Unsorted)
            );

            Console.ReadKey();
        }

        private static void PrintGrid(SearchResults l, SearchResults j, SearchResults b, SearchResults i)
        {

            grid.PrintRow("Min",
                (l.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MinValue.Cycles.ToString("00000000"),
                (j.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.MinValue.Cycles.ToString("00000000"),
                (b.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MinValue.Cycles.ToString("00000000"),
                (i.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.MinValue.Cycles.ToString("00000000")
            );
            grid.PrintRow("Avg",
                (l.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.AvgValue.Cycles.ToString("00000000"),
                (j.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.AvgValue.Cycles.ToString("00000000"),
                (b.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.AvgValue.Cycles.ToString("00000000"),
                (i.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.AvgValue.Cycles.ToString("00000000")
            );
            grid.PrintRow("Max",
                (l.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MaxValue.Cycles.ToString("00000000"),
                (j.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.MaxValue.Cycles.ToString("00000000"),
                (b.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MaxValue.Cycles.ToString("00000000"),
                (i.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.MaxValue.Cycles.ToString("00000000")
            );
            grid.PrintRow("NotFound",
                (l.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.NotFoundValue.Cycles.ToString("00000000"),
                (j.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.NotFoundValue.Cycles.ToString("00000000"),
                (b.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.NotFoundValue.Cycles.ToString("00000000"),
                (i.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.NotFoundValue.Cycles.ToString("00000000")
            );
            grid.PrintLine();
        }
    }
}
