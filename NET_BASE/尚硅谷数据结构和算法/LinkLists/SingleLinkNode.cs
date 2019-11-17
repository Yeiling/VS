namespace 尚硅谷数据结构和算法.LinkLists
{
    /// <summary>
    /// 单链表节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkNode<T>
    {
        /// <summary>
        /// 指针
        /// </summary>
        public SingleLinkNode<T> Next { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public T Data { get; set; }
    }
}
