using System;
using System.Collections.Generic;
using System.Text;
using 数据结构和算法.CommonInterface;

namespace 数据结构和算法.树
{
    /// <summary>
    /// 树
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkTree<T> : ITreeInterface<T>
    {
        #region 属性
        /// <summary>
        /// 根节点
        /// </summary>
        public TreeNode<T> RootNode { get; set; }
        #endregion

        #region 构造函数
        public LinkTree() : this(null) { }
        public LinkTree(TreeNode<T> node) => RootNode = node;
        #endregion

        #region 接口实现
        /// <summary>
        /// 节点总数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => RootNode == null;
        /// <summary>
        /// 获取一个数值
        /// </summary>
        /// <returns></returns>
        public T GetValue()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 树的高度
        /// </summary>
        /// <returns></returns>
        public int Height()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 前序遍历
        /// </summary>
        public void PreOrderTree()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 中序遍历
        /// </summary>
        public void InOrderTree()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 后续遍历
        /// </summary>
        public void PostOrderTree()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
