using System.Collections.Generic;
using BasicAlgorithms.SortingAlgorithms.Models;

namespace BasicAlgorithms.SortingAlgorithms.Interfaces
{
    public interface ISort
    {
        SortResults Sort(List<int> data);
    }
}