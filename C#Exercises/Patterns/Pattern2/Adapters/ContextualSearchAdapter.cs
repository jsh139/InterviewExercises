using Patterns.Pattern2.Requests;

namespace Patterns.Pattern2.Adapters
{
    public class ContextualSearchAdapter : ISearchAdapter
    {
        public void Adapt(SearchContext context)
        {
            if (context.Request is ContextualSearchRequest)
            {
                var request = (ContextualSearchRequest) context.Request;
                context.Max = request.Max;
            }
        }
    }
}
