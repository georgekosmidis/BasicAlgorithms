using BasicAlgorithms.Arrays;
using BasicAlgorithms.Arrays.DataProviders.Models;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using System;

namespace BasicAlgorithms.UI;

public class ArraySearchUI : Grid
{

    private readonly ArraySearchFactory _searchFactory;
    public ArraySearchUI(ArraySearchFactory searchFactory, int tableWith) : base(tableWith)
    {
        _searchFactory = searchFactory;
    }

    public void Print()
    {
        PrintLine();
        PrintRow("Ticks needed to search an item in " + _searchFactory.SampleSize + " integers");
        PrintLine();

        PrintLine();
        PrintRow("", "Linear", "Jump", "Binary", "Interpolation");
        PrintLine();

        PrintRow("Sorted, uniform distribution array");
        PrintLine();
        PrintGrid(
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Linear, EnumArrayDataProviders.SortedAndUniform),
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Jump, EnumArrayDataProviders.SortedAndUniform),
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Binary, EnumArrayDataProviders.SortedAndUniform),
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Interpolation, EnumArrayDataProviders.SortedAndUniform)
        );

        PrintRow("Sorted, not evenly distributed array");
        PrintLine();
        PrintGrid(
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Linear, EnumArrayDataProviders.Sorted),
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Jump, EnumArrayDataProviders.Sorted),
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Binary, EnumArrayDataProviders.Sorted),
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Interpolation, EnumArrayDataProviders.Sorted)
        );

        PrintRow("Unsorted (random) array");
        PrintLine();
        PrintGrid(
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Linear, EnumArrayDataProviders.Unsorted),
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Jump, EnumArrayDataProviders.Unsorted),
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Binary, EnumArrayDataProviders.Unsorted),
            _searchFactory.Estimate(EnumArraysSearchAlgorithms.Interpolation, EnumArrayDataProviders.Unsorted)
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

        PrintRow("Min",
            (l.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MinValue.Ticks.ToString("00000000"),
            (j.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.MinValue.Ticks.ToString("00000000"),
            (b.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MinValue.Ticks.ToString("00000000"),
            (i.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.MinValue.Ticks.ToString("00000000")
        );
        PrintRow("Avg",
            (l.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.AvgValue.Ticks.ToString("00000000"),
            (j.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.AvgValue.Ticks.ToString("00000000"),
            (b.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.AvgValue.Ticks.ToString("00000000"),
            (i.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.AvgValue.Ticks.ToString("00000000")
        );
        PrintRow("Max",
            (l.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MaxValue.Ticks.ToString("00000000"),
            (j.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.MaxValue.Ticks.ToString("00000000"),
            (b.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MaxValue.Ticks.ToString("00000000"),
            (i.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.MaxValue.Ticks.ToString("00000000")
        );
        PrintRow("NotFound",
            (l.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.NotFoundValue.Ticks.ToString("00000000"),
            (j.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + j.NotFoundValue.Ticks.ToString("00000000"),
            (b.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.NotFoundValue.Ticks.ToString("00000000"),
            (i.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + i.NotFoundValue.Ticks.ToString("00000000")
        );
        PrintLine();
    }
}
