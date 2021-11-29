using BasicAlgorithms.Arrays.DataProviders.Models;
using BasicAlgorithms.Arrays.SearchAlgorithms;
using BasicAlgorithms.Arrays.SearchAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using System;

namespace BasicAlgorithms.Arrays;

public class ArraySearchFactory
{
    public int SampleSize { get; }

    public ArraySearchFactory(int sample)
    {
        SampleSize = sample;
    }

    public SearchResults Estimate(EnumArraysSearchAlgorithms searchAlgorithm, EnumArrayDataProviders searchDataProvider)
    {
        var _search = GetSearch(searchAlgorithm);
        var _searchData = new DataProvidersFactory(SampleSize).GetProvider(searchDataProvider);

        var searchResults = new SearchResults()
        {
            ArrayCount = _searchData.Data.Count
        };

        searchResults.MinValue = _search.Find(_searchData.Data, _searchData.MinValue);
        searchResults.AvgValue = _search.Find(_searchData.Data, _searchData.AvgValue);
        searchResults.MaxValue = _search.Find(_searchData.Data, _searchData.MaxValue);
        searchResults.RandomValue = _search.Find(_searchData.Data, _searchData.RandomValue);
        searchResults.NotFoundValue = _search.Find(_searchData.Data, _searchData.NotFoundValue);

        return searchResults;
    }

    private static ISearch GetSearch(EnumArraysSearchAlgorithms searchAlgorithm)
    {
        return searchAlgorithm switch
        {
            EnumArraysSearchAlgorithms.Linear => new LinearSearch(),
            EnumArraysSearchAlgorithms.Jump => new JumpSearch(),
            EnumArraysSearchAlgorithms.Binary => new BinarySearch(),
            EnumArraysSearchAlgorithms.Interpolation => new InterpolationSearch(),
            _ => throw new NotImplementedException("Unknown algorithm '" + nameof(searchAlgorithm) + "'"),
        };
    }
}
