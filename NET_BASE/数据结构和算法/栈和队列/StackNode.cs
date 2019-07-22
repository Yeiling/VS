namespace 数据结构和算法.栈和队列
{
    /// <summary>
    /// 栈节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackQueueNode<T>
    {
        #region 属性字段
        public T Data { get; set; }
        public StackQueueNode<T> PreNode { get; set; }
        public StackQueueNode<T> NextNode { get; set; }
        #endregion

        #region 构造函数
        public StackQueueNode() { }
        public StackQueueNode(T data) : this(data, null, null)
        {
            Data = data;
        }
        public StackQueueNode(T data, StackQueueNode<T> pre, StackQueueNode<T> next)
        {
            Data = data;
            PreNode = pre;
            NextNode = next;
        }
        #endregion
    }
}
