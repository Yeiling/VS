using System.Collections.Generic;
using System.Linq;

namespace Client.HttpTool
{
    public static class ArrayExt
    {
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> Arry) => Arry != null && Arry.Count() > 0;
    }
}
