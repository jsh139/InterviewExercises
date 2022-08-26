using System.Collections.Generic;
using Patterns.Pattern2.Adapters;

namespace Patterns.Pattern2
{
    public interface ISearchAdapterFactory
    {
        List<ISearchAdapter> GetSearchAdapters();
    }
}
