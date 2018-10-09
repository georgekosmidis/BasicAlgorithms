using BasicAlgorithmsArrays.SortingAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithmsArrays.SortingAlgorithms.Interfaces
{
    public interface ISort
    {
        SortResults Sort(List<int> data);
    }
}