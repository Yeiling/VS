namespace 数据结构和算法.单链表.Model
{
    /// <summary>
    /// 节点类---单链表只能找到后继节点
    /// </summary>
    public class Node
    {
        #region 属性
        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 节点指针
        /// </summary>
        public Node Next { get; set; }
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数---空节点/头节点
        /// </summary>
        public Node() { }
        /// <summary>
        /// 构造函数---新节点
        /// </summary>
        /// <param name="data">只有数据，没有节点的链表</param>
        public Node(object data) : this(data, null)
        {
            Data = data;
        }
        /// <summary>
        /// 构造函数---数据节点
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="node">节点指针</param>
        public Node(object data, Node node)
        {
            Data = data;
            Next = node;
        }
        #endregion

    }
}