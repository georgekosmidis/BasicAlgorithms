using SearchAlgorithms.Algorithms;
using SearchAlgorithms.DataProviders;
using SearchAlgorithms.Models;
using SearchAlgorithms.UI;
using System;
using System.Collections.Generic;

namespace SearchAlgorithms
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
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Linear, eSearchDataProviders.SortedAndUniform),
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Jump, eSearchDataProviders.SortedAndUniform),
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Binary, eSearchDataProviders.SortedAndUniform),
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Interpolation, eSearchDataProviders.SortedAndUniform)
            );

            grid.PrintRow("Sorted, not evenly distributed array of " + sample + " integers");
            grid.PrintLine();
            PrintGrid(
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Linear, eSearchDataProviders.Sorted),
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Jump, eSearchDataProviders.Sorted),
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Binary, eSearchDataProviders.Sorted),
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Interpolation, eSearchDataProviders.Sorted)
            );

            grid.PrintRow("Unsorted (random) array of " + sample + " integers");
            grid.PrintLine();
            PrintGrid(
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Linear, eSearchDataProviders.Unsorted),
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Jump, eSearchDataProviders.Unsorted),
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Binary, eSearchDataProviders.Unsorted),
                new SearchFactory(sample).Estimate(eSearchAlgorithms.Interpolation, eSearchDataProviders.Unsorted)
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
