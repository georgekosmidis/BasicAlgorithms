using BasicAlgorithms.Arrays;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using BasicAlgorithms.DataProviders.Models;
using BasicAlgorithmsArrays.SortingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.UI
{
    public class ArraySortUI : Grid
    {

        private ArraySortFactory _sortFactory;
        public ArraySortUI(ArraySortFactory sortFactory, int tableWith) : base(tableWith)
        {
            _sortFactory = sortFactory;
        }

        public void Print()
        {
            this.PrintLine();

            this.PrintRow("Ticks needed to sort " + _sortFactory.SampleSize + " integers");
            this.PrintLine();

            this.PrintLine();
            this.PrintRow("", "Random", "Reversed", "Sorted");
            this.PrintLine();

            PrintGrid("Insertion",
                _sortFactory.Estimate(eArraySortAlgorithms.Insertion, eSearchDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Insertion, eSearchDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Insertion, eSearchDataProviders.Sorted)
            );
            PrintGrid("Selection",
                _sortFactory.Estimate(eArraySortAlgorithms.Selection, eSearchDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Selection, eSearchDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Selection, eSearchDataProviders.Sorted)
            );
            PrintGrid("Bubble",
                _sortFactory.Estimate(eArraySortAlgorithms.Bubble, eSearchDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Bubble, eSearchDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Bubble, eSearchDataProviders.Sorted)
            );
            PrintGrid("Heap",
                _sortFactory.Estimate(eArraySortAlgorithms.Heap, eSearchDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Heap, eSearchDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Heap, eSearchDataProviders.Sorted)
            );
            PrintGrid("Merge",
                _sortFactory.Estimate(eArraySortAlgorithms.Merge, eSearchDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Merge, eSearchDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Merge, eSearchDataProviders.Sorted)
            );
            PrintGrid("Quick",
                _sortFactory.Estimate(eArraySortAlgorithms.Quick, eSearchDataProviders.Unsorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Quick, eSearchDataProviders.ReverseSorted),
                _sortFactory.Estimate(eArraySortAlgorithms.Quick, eSearchDataProviders.Sorted)
            );
        }

        private void PrintGrid(string title, SortResults u, SortResults r, SortResults s)
        {

            this.PrintRow(title,
                u.Ticks.ToString("00000000"),
                r.Ticks.ToString("00000000"),
                s.Ticks.ToString("00000000")
            );
            this.PrintLine();
        }
    }
}
