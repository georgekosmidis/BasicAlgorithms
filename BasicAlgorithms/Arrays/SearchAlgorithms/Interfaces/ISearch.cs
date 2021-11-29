using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Arrays.SearchAlgorithms.Interfaces;

public interface ISearch
{
    SearchResult Find(List<int> data, int value);
}
