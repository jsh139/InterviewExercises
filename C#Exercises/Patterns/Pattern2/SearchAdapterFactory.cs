using System.Collections.Generic;
using Patterns.Pattern2.Adapters;

namespace Patterns.Pattern2
{
    public class SearchAdapterFactory : ISearchAdapterFactory
    {
        private readonly List<ISearchAdapter> _adapters;

        public SearchAdapterFactory(
            CommonSearchAdapter commonSearchAdapter,
            GridSearchAdapter gridSearchAdapter,
            ContextualSearchAdapter contextualSearchAdapter)
        {
            _adapters = new List<ISearchAdapter>
            {
                commonSearchAdapter,
                gridSearchAdapter,
                contextualSearchAdapter
            };
        }

        public List<ISearchAdapter> GetSearchAdapters()
        {
            return _adapters;
        }
    }
}
