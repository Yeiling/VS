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
        public int Count
        {
            get
            {
                if (RootNode == null)
                    return 0;
                else
                    return CountExt(RootNode);
            }
        }
        /// <summary>
        /// 二叉树节点数
        /// </summary>
        /// <param name="node">节点</param>
        /// <returns></returns>
        private int CountExt(TreeNode<T> node)
        {
            if (node != null)
                //int nl = CountExt(node.LeftChild); //左子树高度
                //int nr = CountExt(node.RightChild); //右子树高度
                return CountExt(node.LeftChild) + CountExt(node.RightChild) + 1;
            else
                return 0;
        }

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
        /// 树的高度
        /// </summary>
        /// <returns></returns>
        public int Height() => Height(RootNode);
        /// <summary>
        /// 树的高度
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int Height(TreeNode<T> node)
        {
            if (node != null) //比较左右子树
            {
                int nl = Height(node.LeftChild); //左子树高度
                int nr = Height(node.RightChild); //右子树高度
                return nl > nr ? nl + 1 : nr + 1;
            }
            else
                return 0;
        }

        /// <summary>
        /// 二叉树是否包含值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contain(T key) => Contain(RootNode, key);
        /// <summary>
        /// 二叉树是否包含值
        /// </summary>
        /// <param name="node"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        private bool Contain(TreeNode<T> node, T model)
        {
            bool result = false;
            if (node != null)
            {
                if (node.Data.Equals(model))
                    result = true;
                else
                {
                    result = Contain(node.LeftChild, model);
                    result = Contain(node.RightChild, model);
                }

            }
            return result;
        }

        #region 前序写法
        /// <summary>
        /// 前序遍历
        /// </summary>
        public IEnumerable<T> PreOrderTree(ref Queue<T> queue) => PreOrderTree(RootNode, ref queue);
        /// <summary>
        /// 前序遍历辅助方法
        /// </summary>
        /// <param name="node"></param>
        private IEnumerable<T> PreOrderTree(TreeNode<T> node, ref Queue<T> queue)
        {
            if (node != null)
            {
                //根
                queue.Enqueue(node.Data);
                //左
                PreOrderTree(node.LeftChild, ref queue);
                //右
                PreOrderTree(node.RightChild, ref queue);
            }
            return queue;
        }
        #endregion

        #region 前序扩展写法
        /// <summary>
        /// 前序遍历 
        /// </summary>
        public IEnumerable<T> PreOrderTreeExt(ref Queue<T> queue)
        {
            if (RootNode != null)
            {
                queue.Enqueue(RootNode.Data); //获取根节点
                LinkTree<T> LRNode = null;
                //遍历左子树
                if (RootNode.LeftChild != null)
                {
                    LRNode = new LinkTree<T>(RootNode.LeftChild);
                    LRNode.PreOrderTreeExt(ref queue);
                }
                //遍历右子树
                if (RootNode.RightChild != null)
                {
                    LRNode = new LinkTree<T>(RootNode.RightChild);
                    LRNode.PreOrderTreeExt(ref queue);
                }
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
