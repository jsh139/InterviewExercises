using Patterns.Pattern2.Requests;

namespace Patterns.Pattern2.Adapters
{
    public class GridSearchAdapter : ISearchAdapter
    {
        public void Adapt(SearchContext context)
        {
            if (context.Request is GridSearchRequest)
            {
                context.Pageable = true;
            }
        }
    }
}
