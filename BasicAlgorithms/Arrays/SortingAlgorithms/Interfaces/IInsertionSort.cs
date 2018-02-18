using System.Collections.Generic;
using BasicAlgorithmsArrays.SortingAlgorithms.Models;

namespace BasicAlgorithmsArrays.SortingAlgorithms.Interfaces
{
    public interface ISort
    {
        SortResults Sort(List<int> data);
    }
}