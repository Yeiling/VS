namespace 数据结构和算法.双链表
{
    /// <summary>
    /// 双链表节点---有后继和前驱
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoubleNode<T>
    {
        /// <summary>
        /// 节点数据
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 前驱节点
        /// </summary>
        public DoubleNode<T> PreNode { get; set; }
        /// <summary>
        /// 后继节点
        /// </summary>
        public DoubleNode<T> NextNode { get; set; }

        /// <summary>
        /// 默认构造函数---空节点
        /// </summary>
        public DoubleNode()
        { }

        /// <summary>
        /// 有前驱和后继的节点
        /// </summary>
        /// <param name="model">数据</param>
        /// <param name="prenode">前驱节点</param>
        /// <param name="nextnode">后继节点</param>
        public DoubleNode(T model, DoubleNode<T> prenode, DoubleNode<T> nextnode)
        {
            Data = model;
            PreNode = prenode;
            NextNode = nextnode;
        }
    }
}
