using System;

namespace Patterns.Support
{
    public class CacheProviderPolicy
    {
        public CacheProviderPolicy()
        {
            SlidingExpiration = NoSlidingExpiration;
        }

        /// <summary>
        /// Gets/sets a value specifying a span of time after which the cached object should expire 
        /// if it has not been retrieved during that span of time. This value defaults to NoSlidingExpiration.
        /// </summary>
        public TimeSpan SlidingExpiration { get; set; }

        /// <summary>
        /// Gets a value that is used as the default for SlidingExpiration. This indicates no sliding expiration.
        /// </summary>
        public static readonly TimeSpan NoSlidingExpiration = new TimeSpan(0);
    }
}
