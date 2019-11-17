namespace 尚硅谷数据结构和算法.LinkLists
{
    /// <summary>
    /// 双链表节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoubleLinkNode<T>
    {
        /// <summary>
        /// 前指针
        /// </summary>
        public DoubleLinkNode<T> Previous { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 后指针
        /// </summary>
        public DoubleLinkNode<T> Next { get; set; }
    }
}
