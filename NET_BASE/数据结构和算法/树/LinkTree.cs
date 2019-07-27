using System;
using System.Collections.Generic;
using 数据结构和算法.CommonInterface;

namespace 数据结构和算法.树
{
    /// <summary>
    /// 二叉树
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
        public int Count => 8;

        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => RootNode == null;

        /// <summary>
        /// 根节点的值
        /// </summary>
        /// <returns></returns>
        public T GetRootValue() => RootNode.Data;

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

        #region 前序第一种写法
        /// <summary>
        /// 前序遍历 
        /// </summary>
        public IEnumerable<T> PreOrderTree(ref Queue<T> queue)
        {
            if (RootNode != null)
            {
                queue.Enqueue(RootNode.Data); //获取根节点
                LinkTree<T> LRNode = null;
                //遍历左子树
                if (RootNode.LeftChild != null)
                {
                    LRNode = new LinkTree<T>(RootNode.LeftChild);
                    LRNode.PreOrderTree(ref queue);
                }
                //遍历右子树
                if (RootNode.RightChild != null)
                {
                    LRNode = new LinkTree<T>(RootNode.RightChild);
                    LRNode.PreOrderTree(ref queue);
                }
            }
            return queue;
        }
        #endregion

        #region 前序第二种写法
        /// <summary>
        /// 前序遍历
        /// </summary>
        public IEnumerable<T> PreOrderTreeExt(ref Queue<T> queue) => PreOrderTreeExt(RootNode, ref queue);
        /// <summary>
        /// 前序遍历辅助方法
        /// </summary>
        /// <param name="node"></param>
        private IEnumerable<T> PreOrderTreeExt(TreeNode<T> node, ref Queue<T> queue)
        {
            if (node != null)
            {
                //根
                queue.Enqueue(node.Data);
                //左
                PreOrderTreeExt(node.LeftChild, ref queue);
                //右
                PreOrderTreeExt(node.RightChild, ref queue);
            }
            return queue;
        }
        #endregion

        #region 中序写法
        /// <summary>
        /// 中序遍历
        /// </summary>
        public IEnumerable<T> InOrderTree(ref Queue<T> queue) => InOrderTree(RootNode, ref queue);
        /// <summary>
        /// 中序遍历辅助方法
        /// </summary>
        /// <param name="node"></param>
        private IEnumerable<T> InOrderTree(TreeNode<T> node, ref Queue<T> queue)
        {
            if (node != null)
            {
                //左
                InOrderTree(node.LeftChild, ref queue);
                //根
                queue.Enqueue(node.Data);
                //右
                InOrderTree(node.RightChild, ref queue);
            }
            return queue;
        }
        #endregion

        #region 后续写法
        /// <summary>
        /// 后续遍历
        /// </summary>
        public IEnumerable<T> PostOrderTree(ref Queue<T> queue) => PostOrderTree(RootNode, ref queue);
        /// <summary>
        /// 后序遍历辅助方法
        /// </summary>
        /// <param name="node"></param>
        /// <param name="queue"></param>
        /// <returns></returns>
        private IEnumerable<T> PostOrderTree(TreeNode<T> node, ref Queue<T> queue)
        {
            if (node != null)
            {
                //左
                InOrderTree(node.LeftChild, ref queue);
                //右
                InOrderTree(node.RightChild, ref queue);
                //根
                queue.Enqueue(node.Data);
            }
            return queue;
        }
        #endregion
        #endregion
    }
}
