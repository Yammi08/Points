using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Extented
{
    public static class Array
    {
        public static IEnumerable<C> Where<T, C>(this IEnumerable<T> items, Func<T, bool> func) where C : class where T : class
        {
            foreach (var item in items)
            {
                if(func(item))
                    yield return item as C;
            }
        }
    }
}
