using BasicAlgorithms.Arrays.SortingAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Arrays.SortingAlgorithms.Interfaces;

public interface ISort
{
    SortResults Sort(List<int> data);
}
