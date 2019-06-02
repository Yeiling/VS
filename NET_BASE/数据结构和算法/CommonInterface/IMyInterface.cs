namespace 数据结构和算法.CommonInterface
{
    /// <summary>
    /// 线性数据结构公共接口
    /// </summary>
    public interface IMyInterface<T>
    {
        #region 属性
        /// <summary>
        /// 数组长度
        /// </summary>
        int Length { get; }
        /// <summary>
        /// 元素个数
        /// </summary>
        int Count { get; }
        #endregion

        #region 增
        /// <summary>
        /// 添加一个元素
        /// </summary>
        /// <param name="t"></param>
        void Add(T t);
        /// <summary>
        /// 指定位置添加一个元素
        /// </summary>
        /// <param name="t"></param>
        /// <param name="index"></param>
        void Add(int index, T t);
        #endregion

        #region 删
        /// <summary>
        /// 移除一个元素
        /// </summary>
        /// <param name="t"></param>
        void Remove(T t);
        /// <summary>
        /// 从指定索引位置移除一个元素
        /// </summary>
        /// <param name="t"></param>
        /// <param name="index"></param>
        void Remove(int index);
        #endregion

        #region 查
        /// <summary>
        /// 获取索引为index的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T Get(int index);
        /// <summary>
        /// 某一个元素的所在索引位置
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Indexof(T t);
        #endregion

        #region 改
        /// <summary>
        /// 改成新的值
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newModel"></param>
        /// <returns></returns>
        T Replace(int index, T newModel);
        #endregion

        #region 其他
        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
        /// <summary>
        /// 是否包含某个元素
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool Contains(T t);
        #endregion

    }
}
