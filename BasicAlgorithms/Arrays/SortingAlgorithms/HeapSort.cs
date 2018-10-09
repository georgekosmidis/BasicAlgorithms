using BasicAlgorithmsArrays.SortingAlgorithms.Interfaces;
using BasicAlgorithmsArrays.SortingAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithmsArrays.SortingAlgorithms
{
    public class HeapSort : ISort
    {

        /// <summary>
        /// Heap Sort Algorithm [Time: O(n*Logn), Space: O(n)]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public SortResults Sort(List<int> data)
        {
            var results = new SortResults();
            var length = data.Count;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            //rearrange array to heap array sort
            for (var i = length / 2 - 1; i >= 0; i--)
                Heapify(data, length, i);

            //the largest element is first, move it to the end
            // reheapify everything (except the last) to bring the largest at the first position
            for (int i = length - 1; i >= 0; i--)
            {
                var tmp = data[0];
                data[0] = data[i];
                data[i] = tmp;

                Heapify(data, i, 0);
            }

            watch.Stop();
            results.Ticks = watch.ElapsedTicks;
            results.SortedData = data;
            return results;
        }


        //space O(n) because of recursion, could be modified to a loop for O(1) complexity
        private void Heapify(List<int> data, int length, int largest)
        {

            //assume largest and get left and right that should be smaller
            var new_largest = largest;
            var left = 2 * largest + 1;//left branch of heap tree
            var right = 2 * largest + 2;//right branch of heap tree

            //if left is larger, get that as the new largest
            if (left < length && data[left] > data[new_largest])
                new_largest = left;

            //if right is larger, get that as the new largest
            if (right < length && data[right] > data[new_largest])
                new_largest = right;

            //if there is a change in largest swap
            // and recurse with the new largest
            if (new_largest != largest)
            {
                var tmp = data[largest];
                data[largest] = data[new_largest];
                data[new_largest] = tmp;

                Heapify(data, length, new_largest);
            }
        }
    }
}
