using Patterns.Support;

namespace Patterns.Pattern2.Requests
{
    public class GridSearchRequest : ISearchRequest
    {
        public string CacheKey { get; set; }
    }
}
