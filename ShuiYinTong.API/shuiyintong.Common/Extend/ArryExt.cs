using System.Collections.Generic;
using System.Linq;

namespace shuiyintong.Common.Extend
{
    public static class ArryExt
    {
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> lst) => lst != null && lst.Count() > 0;
    }
}
