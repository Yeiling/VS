using System.Text;

namespace 数据结构和算法.单链表
{
    /// <summary>
    /// 模拟单链表
    /// </summary>
    public class SingLinkList<T>
    {
        #region 字段和属性
        /// <summary>
        /// 头结点，不存储数据和指针，为了编写方便
        /// </summary>
        private Node<T> header = new Node<T>();
        /// <summary>
        /// 节点总数
        /// </summary>
        private int _counts { get; set; }
        public int Count => _counts - 1; //数组元素个数---不包括头结点
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index">索引位置</param>
        /// <returns></returns>
        public Node<T> this[int index] => Get(index);
        #endregion

        #region 接口方法实现
        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="t">新元素</param>
        public void Add(T t) => Add(_counts, t);

        /// <summary>
        /// 制定位置添加元素
        /// </summary>
        /// <param name="index">要添加的索引位置</param>
        /// <param name="t">新元素</param>
        public void Add(int index, T obj)
        {
            //找到要添加的索引index位置节点的前一个节点
            Node<T> indexNode = header;
            for (int i = 0; i < index; i++)
                indexNode = indexNode.Next;

            //创建新节点
            Node<T> newNode = new Node<T>(obj)
            {
                //赋值---顺序不能反过来
                Next = indexNode.Next //新节点的后继指向索引节点的next
            };
            indexNode.Next = newNode;//索引节点的next指向新节点

            //数量增加
            _counts++;
        }

        /// <summary>
        /// 是否含有元素
        /// </summary>
        /// <param name="t">元素</param>
        /// <returns>是否包含</returns>
        public bool Contains(object t)
        {
            Node<T> temp = header;
            for (int i = 0; i <= _counts; i++)
            {
                temp = temp.Next;
                if (temp.Data.Equals(t))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 依据索引查找元素
        /// </summary>
        /// <param name="index">索引位置</param>
        /// <returns>目标元素</returns>
        public Node<T> Get(int index)
        {
            Node<T> temp = header;
            for (int i = 0; i <= index; i++)
                temp = temp.Next;
            return temp;
        }

        /// <summary>
        /// 元素的位置
        /// </summary>
        /// <param name="t">元素</param>
        /// <returns>索引位置</returns>
        public int Indexof(object t)
        {
            Node<T> temp = header;
            for (int i = 0; i <= _counts; i++)
            {
                temp = temp.Next;
                if (temp.Data.Equals(t))
                    return i;
            }
            return 0;
        }

        /// <summary>
        /// 数组是否为空
        /// </summary>
        /// <returns>是否为空</returns>
        public bool IsEmpty() => Count == 0;

        /// <summary>
        /// 移除一个元素(依据索引)
        /// </summary>
        /// <param name="index">索引位置</param>
        public void Remove(int index)
        {
            //找到索引index位置节点的前一个节点
            Node<T> indexNode = header;
            for (int i = 0; i < index; i++) //索引位置前一个节点
                indexNode = indexNode.Next;

            Node<T> temp = indexNode.Next; //索引位置节点
            indexNode.Next = temp.Next;
        }

        /// <summary>
        /// 替换元素
        /// </summary>
        /// <param name="index">索引位置</param>
        /// <param name="newModel">新元素</param>
        /// <returns>返回新元素</returns>
        public void Replace(int index, T newModel)
        {
            //找到索引index位置节点的前一个节点,并赋值
            Get(index).Data = newModel;
        }

        /// <summary>
        /// 重写tosting方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> temp = header.Next;
            for (int i = 0; i <= _counts; i++)
            {
                if (temp != null && temp.Data != null)
                {
                    sb.Append(temp.Data + ",");
                    temp = temp.Next;
                }
            }
            return sb.ToString().TrimEnd(',');
        }
        #endregion
    }
}
