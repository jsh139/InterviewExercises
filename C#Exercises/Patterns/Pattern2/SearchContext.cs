using Patterns.Support;

namespace Patterns.Pattern2
{
    public class SearchContext
    {
        public ISearchRequest Request { get; set; }
        public string CacheKey { get; set; }
        public bool Pageable { get; set; }
        public int? Max { get; set; }
    }
}
