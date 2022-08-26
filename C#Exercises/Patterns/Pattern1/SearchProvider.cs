using System;
using Patterns.Support;

namespace Patterns.Pattern1
{
    public abstract class SearchProvider
    {
        protected ICacheManager CacheManager { get; private set; }

        protected SearchProvider(ICacheManager cacheManager)
        {
            CacheManager = cacheManager;
        }

        protected T GetData<T>(ISearchRequest request, Func<ISearchRequest, ISearchResults, T> getDataFunc)
            where T : class, ISearchResults
        {
            string cacheKey = string.Format("{0}-data", request.CacheKey);

            T data = CacheManager.Get<T>(cacheKey);

            if (data == null)
            {
                data = getDataFunc(request, data);

                var cacheProviderPolicy = new CacheProviderPolicy
                {
                    SlidingExpiration = new TimeSpan(0, 15, 0)
                };

                CacheManager.Put(cacheKey, data, cacheProviderPolicy);
            }

            return data;
        }
    }
}
