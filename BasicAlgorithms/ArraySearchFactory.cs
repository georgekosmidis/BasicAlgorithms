using BasicAlgorithms.ArraySearchAlgorithms;
using BasicAlgorithms.ArraySearchAlgorithms.Interfaces;
using BasicAlgorithms.ArraySearchAlgorithms.Models;
using BasicAlgorithms.DataProviders;
using BasicAlgorithms.DataProviders.Interfaces;
using BasicAlgorithms.DataProviders.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms
{
    public class ArraySearchFactory
    {
        int _sample;
        public ArraySearchFactory(int sample)
        {
            _sample = sample;
        }
        public SearchResults Estimate(eArraySearchAlgorithms searchAlgorithm, eSearchDataProviders searchDataProvider)
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

        private ISearch GetSearch(eArraySearchAlgorithms searchAlgorithm)
        {
            switch (searchAlgorithm)
            {
                case eArraySearchAlgorithms.Linear:
                    return new LinearSearch();
                case eArraySearchAlgorithms.Jump:
                    return new JumpSearch();
                case eArraySearchAlgorithms.Binary:
                    return new BinarySearch();
                case eArraySearchAlgorithms.Interpolation:
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
