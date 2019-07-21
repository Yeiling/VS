namespace 数据结构和算法.树
{
    public class TreeNode<T>
    {
        #region 属性
        /// <summary>
        /// 节点数据
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 左节点子树
        /// </summary>
        public TreeNode<T> LeftChild { get; set; }
        /// <summary>
        /// 右节点子树
        /// </summary>
        public TreeNode<T> RightChild { get; set; }
        #endregion

        #region 构造函数
        /// <summary>
        /// 空节点
        /// </summary>
        public TreeNode() { }
        /// <summary>
        /// 没有左右节点的节点
        /// </summary>
        /// <param name="data"></param>
        public TreeNode(T data) : this(data, null, null) => Data = data;
        /// <summary>
        /// 有左右节点的节点
        /// </summary>
        /// <param name="data"></param>
        /// <param name="leftNode"></param>
        /// <param name="rightNode"></param>
        public TreeNode(T data, TreeNode<T> leftNode, TreeNode<T> rightNode)
        {
            Data = data;
            LeftChild = leftNode;
            RightChild = rightNode;
        }
        #endregion
    }
}