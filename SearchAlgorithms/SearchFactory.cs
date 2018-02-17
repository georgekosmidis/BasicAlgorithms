using SearchAlgorithms.Algorithms;
using SearchAlgorithms.DataProviders;
using SearchAlgorithms.Interfaces;
using SearchAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms
{
    public class SearchFactory
    {
        int _sample;
        public SearchFactory(int sample)
        {
            _sample = sample;
        }
        public SearchResults Estimate(eSearchAlgorithms searchAlgorithm, eSearchDataProviders searchDataProvider)
        {
            var _search = GetSearch(searchAlgorithm);
            var _searchData = GetSearchData(searchDataProvider);

            var searchResults = new SearchResults()
            {
                AlgorithmName = _search.Name,
                ArrayCount = _searchData.Data.Count,
                SearchDataName = _searchData.Name
            };

            searchResults.LeftValue = _search.Find(_searchData.Data, _searchData.MinValue);
            searchResults.MiddleValue = _search.Find(_searchData.Data, _searchData.AvgValue);
            searchResults.RightValue = _search.Find(_searchData.Data, _searchData.MaxValue);
            searchResults.RandomValue = _search.Find(_searchData.Data, _searchData.RandomValue);
            searchResults.NotFoundValue = _search.Find(_searchData.Data, _searchData.NotFoundValue);

            return searchResults;
        }

        private ISearch GetSearch(eSearchAlgorithms searchAlgorithm)
        {
            switch (searchAlgorithm)
            {
                case eSearchAlgorithms.Linear:
                    return new LinearSearch();
                case eSearchAlgorithms.Jump:
                    return new JumpSearch();
                case eSearchAlgorithms.Binary:
                    return new BinarySearch();
                case eSearchAlgorithms.Interpolation:
                    return new InterpolationSearch();
            }

            throw new NotImplementedException("Unknown algorithm '" + nameof(searchAlgorithm) + "'");
        }

        private ISearchData GetSearchData(eSearchDataProviders searchData)
        {
            switch (searchData)
            {
                case eSearchDataProviders.SortedAndUniform:
                    return new SortedAndUniformProvider(_sample);
                case eSearchDataProviders.Sorted:
                    return new SortedProvider(_sample);
                case eSearchDataProviders.Unsorted:
                    return new UnsortedProvider(_sample);
            }

            throw new NotImplementedException("Unknown data provider '" + nameof(searchData) + "'");
        }
    }
}
