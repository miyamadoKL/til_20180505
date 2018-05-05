using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_IEnumerable_T
{
    public static class OriginalExtMethod
    {
        public static IEnumerable<T> Trace<T>(this IEnumerable<T> source)
        {
            foreach (var item in source) {
                Console.WriteLine(item);
                yield return item;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = Enumerable.Range(0, 99);
            var query = list.OrderBy(x => Guid.NewGuid()).Take(10).Select(x => x * x).Trace();
            foreach(var item in query) {}
        }
    }
}
