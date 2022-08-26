using Patterns.Support;

namespace Patterns.Pattern2.Requests
{
    public class ContextualSearchRequest : ISearchRequest
    {
        public string CacheKey { get; set; }
        public int Max { get; set; }
    }
}
