using System.Collections.Generic;

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
        int Count { get; }
        /// <summary>
        /// 二叉树高度
        /// </summary>
        /// <returns></returns>
        int Height();
        /// <summary>
        /// 是否包含数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Contain(T key);
        /// <summary>
        /// 前序遍历
        /// </summary>
        IEnumerable<T> PreOrderTree(ref Queue<T> queue);
        /// <summary>
        /// 中序遍历
        /// </summary>
        IEnumerable<T> InOrderTree(ref Queue<T> queue);
        /// <summary>
        /// 后序遍历
        /// </summary>
        IEnumerable<T> PostOrderTree(ref Queue<T> queue);
    }
}
