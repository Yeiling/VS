using System;

namespace 尚硅谷数据结构和算法.LinkLists
{
    public class DoubleLinkList<T>
    {
        /// <summary>
        /// 头结点
        /// </summary>
        public DoubleLinkNode<T> Header { get; set; }
        /// <summary>
        /// 节点数
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 尾节点
        /// </summary>
        public DoubleLinkNode<T> Tail { get; set; }
        public DoubleLinkList()
        {
            Header = new DoubleLinkNode<T> { Data = default(T), Previous = null, Next = null };
        }

        /// <summary>
        /// 双链表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Count == 0;

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="t"></param>
        /// <param name="func"></param>
        public void Add(T t, Func<T, T, bool> func = null)
        {
            DoubleLinkNode<T> newNode = new DoubleLinkNode<T> { Previous = null, Data = t, Next = null };
            if (Count == 0)
            {
                Header.Next = newNode;
                newNode.Previous = Header;
                Tail = newNode;
                Count++;
            }
            else
            {
                DoubleLinkNode<T> tmp = Header.Next;
                if (func == null)
                {
                    #region 没有标记尾节点写法---遍历所有节点
                    //while (true)
                    //{
                    //    if (tmp.Next != null)
                    //        tmp = tmp.Next;
                    //    else
                    //    {
                    //        tmp.Next = newNode;
                    //        newNode.Previous = tmp;
                    //        Count++;
                    //        break;
                    //    }
                    //} 
                    #endregion

                    #region 添加尾节点---更快
                    newNode.Previous = Tail;
                    Tail.Next = newNode;
                    Tail = newNode;
                    Count++;
                    #endregion
                }
                else
                {
                    while (true)
                    {
                        if (func(tmp.Data, t)) //tmp.Data<t
                        {
                            if (tmp.Next != null)
                                tmp = tmp.Next;
                            else
                            {
                                newNode.Next = tmp.Next;
                                tmp.Next = newNode;
                                newNode.Previous = tmp;

                                if (tmp.Next != null)
                                    tmp.Next.Previous = newNode;

                                Count++;
                                break;
                            }
                        }
                        else
                        {
                            newNode.Next = tmp;
                            newNode.Previous = tmp.Previous;
                            tmp.Previous.Next = newNode;
                            tmp.Previous = newNode;
                            Count++;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 双联表反转
        /// </summary>
        /// <returns></returns>
        public DoubleLinkList<T> Reverse()
        {
            //除了头结点外，每个交换头和尾指针
            return null;


        }

    }
}
