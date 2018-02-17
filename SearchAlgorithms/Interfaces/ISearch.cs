using SearchAlgorithms.Models;
using System.Collections.Generic;

namespace SearchAlgorithms.Interfaces
{
    public interface ISearch
    {
        string Name { get; }
        SearchResult Find(List<int> data, int value);
    }
}