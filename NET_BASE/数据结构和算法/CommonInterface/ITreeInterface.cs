namespace 数据结构和算法.CommonInterface
{
    /// <summary>
    /// 二叉树接口
    /// </summary>
    public interface ITreeInterface<T>
    {
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
        /// <summary>
        /// 节点总数
        /// </summary>
        /// <returns></returns>
        int Count();
        /// <summary>
        /// 二叉树高度
        /// </summary>
        /// <returns></returns>
        int Height();
        /// <summary>
        /// 获取值
        /// </summary>
        /// <returns></returns>
        T GetValue();
        /// <summary>
        /// 前序遍历
        /// </summary>
        void PreOrderTree();
        /// <summary>
        /// 中序遍历
        /// </summary>
        void InOrderTree();
        /// <summary>
        /// 后序遍历
        /// </summary>
        void PostOrderTree();
    }
}
