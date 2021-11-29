namespace BasicAlgorithms.Arrays.SearchAlgorithms.Models;

public class SearchResults
{
    public int ArrayCount { get; set; }
    public SearchResult MinValue { get; set; } = new SearchResult();
    public SearchResult MaxValue { get; set; } = new SearchResult();
    public SearchResult AvgValue { get; set; } = new SearchResult();
    public SearchResult RandomValue { get; set; } = new SearchResult();
    public SearchResult NotFoundValue { get; set; } = new SearchResult();
}
