namespace Patterns.Pattern2.Adapters
{
    public class CommonSearchAdapter : ISearchAdapter
    {
        public void Adapt(SearchContext context)
        {
            if (!string.IsNullOrEmpty(context.Request.CacheKey))
            {
                context.CacheKey = context.Request.CacheKey;
            }
            else
            {
                context.CacheKey = context.Request.GetType().ToString();
            }
        }
    }
}
