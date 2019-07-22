using System;
using System.Text;

namespace 数据结构和算法.栈和队列
{
    public class LinkQueue<T>
    {
        #region 字段
        /// <summary>
        /// 头节点---方便操作，不计入总数
        /// </summary>
        private StackQueueNode<T> Header = new StackQueueNode<T>();
        /// <summary>
        /// 游标节点
        /// </summary>
        private StackQueueNode<T> ClusterNode = new StackQueueNode<T>();
        /// <summary>
        /// 栈节点数量
        /// </summary>
        private int Counts { get; set; }
        #endregion

        #region 属性
        public int Count => Counts;
        #endregion

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="data"></param>
        public void EnQueue(T data)
        {
            StackQueueNode<T> newNode = new StackQueueNode<T>(data);
            if (Counts == 0) //头结点第一次记录，之后不动
            {
                newNode.PreNode = Header;  //注:赋值顺序
                Header.NextNode = newNode;
            }
            //游标节点(也是从头结点开始移动)每增加元素都动一次
            newNode.PreNode = ClusterNode; //顺序不能反
            ClusterNode.NextNode = newNode;

            //游标节点移动一次
            ClusterNode = newNode;
            Counts++;
        }
        /// <summary>
        /// 删除一个
        /// </summary>
        /// <param name="data"></param>
        public void DeQueue()
        {
            if (Counts == 0)
                throw new Exception("没有数据可供删除");

            ClusterNode = ClusterNode.PreNode;
            ClusterNode.NextNode = null;

            if (Counts > 1)
            {
                Header.NextNode.NextNode.PreNode = Header; //顺序不能反
                Header.NextNode = Header.NextNode.NextNode;
            }
            else
                Header.NextNode = null;

            Counts--;
        }
        /// <summary>
        /// 获取栈顶元素
        /// </summary>
        /// <returns></returns>
        public T FirstQueueElement() => Header.NextNode.Data;
        /// <summary>
        /// 栈转换成数组
        /// </summary>
        /// <returns></returns>
        public T[] ToArry()
        {
            T[] arry = new T[Counts];
            StackQueueNode<T> node = Header.NextNode;
            int i = 0;
            while (node != null)
            {
                arry[i++] = node.Data;
                node = node.NextNode;
            }
            return arry;
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Counts == 0;
        /// <summary>
        /// 重写ToString()方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder(Counts * 2);

            StackQueueNode<T> node = Header.NextNode;
            while (node != null)
            {
                result.Append(node.Data + ",");
                node = node.NextNode;
            }
            return result.ToString().TrimEnd(',');
        }

    }
}
