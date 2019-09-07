using System.Collections.Generic;

namespace PM.Entity.EasyUIEntity
{
    /// <summary>
    /// EasyUI数据返回值
    /// </summary>
    public class EasyUIData<T>
    {
        /// <summary>
        /// 总数量
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 数据集合
        /// </summary>
        public IEnumerable<T> Rows { get; set; }

    }
}
