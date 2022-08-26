using Patterns.Support;

namespace Patterns.Pattern2.Requests
{
    public class DefaultSearchRequest : ISearchRequest
    {
        public string CacheKey { get; set; }
    }
}
