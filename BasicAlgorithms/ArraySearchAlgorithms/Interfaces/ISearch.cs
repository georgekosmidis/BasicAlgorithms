using BasicAlgorithms.ArraySearchAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.ArraySearchAlgorithms.Interfaces
{
    public interface ISearch
    {
        SearchResult Find(List<int> data, int value);
    }
}