using Patterns.Support;

namespace Patterns.Pattern2
{
    public class SearchPreparer : ISearchPreparer
    {
        private readonly ISearchAdapterFactory _searchAdapterFactory;

        public SearchPreparer(ISearchAdapterFactory searchAdapterFactory)
        {
            _searchAdapterFactory = searchAdapterFactory;
        }

        public void Prepare(ISearchRequest searchRequest)
        {
            var context = new SearchContext
            {
                Request = searchRequest,
            };

            foreach (var adapter in _searchAdapterFactory.GetSearchAdapters())
            {
                adapter.Adapt(context);
            }
        }
    }
}
