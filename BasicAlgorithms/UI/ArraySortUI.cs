using BasicAlgorithms.Arrays;
using BasicAlgorithms.Arrays.DataProviders.Models;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;

namespace BasicAlgorithms.UI;

public class ArraySortUI : Grid
{

    private readonly ArraySortFactory _sortFactory;
    public ArraySortUI(ArraySortFactory sortFactory, int tableWith) : base(tableWith)
    {
        _sortFactory = sortFactory;
    }

    public void Print()
    {
        PrintLine();

        PrintRow("Ticks needed to sort " + _sortFactory.SampleSize + " integers");
        PrintLine();

        PrintLine();
        PrintRow("", "Random", "Reversed", "Sorted");
        PrintLine();

        PrintGrid("Insertion",
            _sortFactory.Estimate(EnumArraySortAlgorithms.Insertion, EnumArrayDataProviders.Unsorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Insertion, EnumArrayDataProviders.ReverseSorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Insertion, EnumArrayDataProviders.Sorted)
        );
        PrintGrid("Selection",
            _sortFactory.Estimate(EnumArraySortAlgorithms.Selection, EnumArrayDataProviders.Unsorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Selection, EnumArrayDataProviders.ReverseSorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Selection, EnumArrayDataProviders.Sorted)
        );
        PrintGrid("Bubble",
            _sortFactory.Estimate(EnumArraySortAlgorithms.Bubble, EnumArrayDataProviders.Unsorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Bubble, EnumArrayDataProviders.ReverseSorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Bubble, EnumArrayDataProviders.Sorted)
        );
        PrintGrid("Heap",
            _sortFactory.Estimate(EnumArraySortAlgorithms.Heap, EnumArrayDataProviders.Unsorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Heap, EnumArrayDataProviders.ReverseSorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Heap, EnumArrayDataProviders.Sorted)
        );
        PrintGrid("Merge",
            _sortFactory.Estimate(EnumArraySortAlgorithms.Merge, EnumArrayDataProviders.Unsorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Merge, EnumArrayDataProviders.ReverseSorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Merge, EnumArrayDataProviders.Sorted)
        );
        PrintGrid("Quick",
            _sortFactory.Estimate(EnumArraySortAlgorithms.Quick, EnumArrayDataProviders.Unsorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Quick, EnumArrayDataProviders.ReverseSorted),
            _sortFactory.Estimate(EnumArraySortAlgorithms.Quick, EnumArrayDataProviders.Sorted)
        );
    }

    private void PrintGrid(string title, SortResults u, SortResults r, SortResults s)
    {
        PrintRow(title,
            u.Ticks.ToString("00000000"),
            r.Ticks.ToString("00000000"),
            s.Ticks.ToString("00000000")
        );
        PrintLine();
    }
}
