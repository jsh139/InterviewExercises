using System;
using System.Threading.Tasks;
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

        protected async Task<T> GetData<T>(ISearchRequest request, Func<ISearchRequest, ISearchResults, T> getDataFunc)
            where T : class, ISearchResults
        {
            string cacheKey = string.Format("{0}-data", request.CacheKey);

            T data = await CacheManager.GetAsync<T>(cacheKey);

            if (data == null)
            {
                data = getDataFunc(request, data);

                var cacheProviderPolicy = new CacheProviderPolicy
                {
                    SlidingExpiration = new TimeSpan(0, 15, 0)
                };

                await CacheManager.PutAsync(cacheKey, data, cacheProviderPolicy);
            }

            return data;
        }
    }
}
