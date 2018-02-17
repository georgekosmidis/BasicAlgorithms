using BasicAlgorithms.ArraySearchAlgorithms;
using BasicAlgorithms.DataProviders;
using BasicAlgorithms.Models;
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
                (l.LeftValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.LeftValue.Cycles.ToString("00000000"),
                (j.LeftValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.LeftValue.Cycles.ToString("00000000"),
                (b.LeftValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.LeftValue.Cycles.ToString("00000000"),
                (i.LeftValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.LeftValue.Cycles.ToString("00000000")
            );
            grid.PrintRow("Avg",
                (l.MiddleValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MiddleValue.Cycles.ToString("00000000"),
                (j.MiddleValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.MiddleValue.Cycles.ToString("00000000"),
                (b.MiddleValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MiddleValue.Cycles.ToString("00000000"),
                (i.MiddleValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.MiddleValue.Cycles.ToString("00000000")
            );
            grid.PrintRow("Max",
                (l.RightValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.RightValue.Cycles.ToString("00000000"),
                (j.RightValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.RightValue.Cycles.ToString("00000000"),
                (b.RightValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.RightValue.Cycles.ToString("00000000"),
                (i.RightValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.RightValue.Cycles.ToString("00000000")
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
