using BasicAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Interfaces
{
    public interface ISearch
    {
        SearchResult Find(List<int> data, int value);
    }
}