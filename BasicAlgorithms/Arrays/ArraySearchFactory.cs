using BasicAlgorithms.Arrays.SearchAlgorithms;
using BasicAlgorithms.Arrays.SearchAlgorithms.Interfaces;
using BasicAlgorithms.Arrays.SearchAlgorithms.Models;
using BasicAlgorithms.DataProviders;
using BasicAlgorithms.DataProviders.Interfaces;
using BasicAlgorithms.DataProviders.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Arrays
{
    public class ArraySearchFactory
    {
        public int SampleSize { get; }
        public ArraySearchFactory(int sample)
        {
            SampleSize = sample;
        }
        public SearchResults Estimate(eArraysSearchAlgorithms searchAlgorithm, eSearchDataProviders searchDataProvider)
        {
            var _search = GetSearch(searchAlgorithm);
            var _searchData = GetSearchData(searchDataProvider);

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

        private ISearch GetSearch(eArraysSearchAlgorithms searchAlgorithm)
        {
            switch (searchAlgorithm)
            {
                case eArraysSearchAlgorithms.Linear:
                    return new LinearSearch();
                case eArraysSearchAlgorithms.Jump:
                    return new JumpSearch();
                case eArraysSearchAlgorithms.Binary:
                    return new BinarySearch();
                case eArraysSearchAlgorithms.Interpolation:
                    return new InterpolationSearch();
            }

            throw new NotImplementedException("Unknown algorithm '" + nameof(searchAlgorithm) + "'");
        }

        private ISearchData GetSearchData(eSearchDataProviders searchData)
        {
            switch (searchData)
            {
                case eSearchDataProviders.SortedAndUniform:
                    return new SortedAndUniformProvider(SampleSize);
                case eSearchDataProviders.Sorted:
                    return new SortedProvider(SampleSize);
                case eSearchDataProviders.Unsorted:
                    return new UnsortedProvider(SampleSize);
            }

            throw new NotImplementedException("Unknown data provider '" + nameof(searchData) + "'");
        }
    }
}
