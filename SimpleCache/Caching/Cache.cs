using System;
using System.Collections.Generic;

namespace Cache.Caching
{
    public class Cache<TKey, TData>
    {
        private readonly Dictionary<TKey, TData> _cachedData = new Dictionary<TKey, TData>();

        public TData Get(TKey key, Func<TKey, TData> getForTheFirstTime)
        {
            if (!_cachedData.ContainsKey(key))
            {
                _cachedData[key] = getForTheFirstTime(key);
            }
            return _cachedData[key];
        }
    }
}
