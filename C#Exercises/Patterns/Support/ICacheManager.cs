using System.Threading.Tasks;

namespace Patterns.Support
{
    public interface ICacheManager
    {
        T Get<T>(string cacheKey) where T : class;
        Task<T> GetAsync<T>(string cacheKey) where T : class;

        void Put<T>(string cacheKey, T objectInstance, CacheProviderPolicy cacheProviderPolicy = null)
            where T : class;
        Task PutAsync<T>(string cacheKey, T objectInstance, CacheProviderPolicy cacheProviderPolicy = null)
            where T : class;
    }
}
