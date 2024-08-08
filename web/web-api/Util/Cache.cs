using System;
using System.Runtime.Caching;

namespace web_api.Util
{
    public class Cache
    {
        private static readonly MemoryCache cache = MemoryCache.Default;

        public static object getCache(string key)
        {
            return cache.Get(key);
        }

        public static void setCache(string key, object lista, int tempoSegundos)
        {
            cache.Set(key, lista, DateTimeOffset.Now.AddSeconds(tempoSegundos));
        }

        public static void clearCache(string key)
        {
            cache.Remove(key);
        }
    }
}