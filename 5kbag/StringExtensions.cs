using System;
using System.Runtime.Caching;

namespace _5kbag
{
    public static class StringExtensions
    {
        public static void Poke(this string value, int loc, uint item)
        {
            var policy = new CacheItemPolicy { SlidingExpiration = TimeSpan.FromHours(8) };
            MemoryCache.Default.Add(loc.ToString(), item, policy);
        }

        public static uint Peek(this string value, int loc)
        {
            return (uint)MemoryCache.Default.Get(loc.ToString()); ;
        }
    }
}
