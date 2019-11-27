using System;
using System.Collections.Generic;
using System.Text;

namespace 尚硅谷数据结构和算法.LinkLists
{
    /// <summary>
    /// 环形链表
    /// </summary>
    public class CircleList<T>
    {
        /// <summary>
        /// 第一个节点
        /// </summary>
        private SingleLinkNode<T> FirstNode { get; set; }
        /// <summary>
        /// 当前戒电脑
        /// </summary>
        private SingleLinkNode<T> CurrentNode { get; set; }
        /// <summary>
        /// 数量个数
        /// </summary>
        private int Count { get; set; }

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="t"></param>
        public void Add(T t)
        {
            SingleLinkNode<T> newNode = new SingleLinkNode<T> { Data = t, Next = null };
            if (Count == 0)
            {
                FirstNode = newNode;
                FirstNode.Next = FirstNode;
                CurrentNode = FirstNode;
            }
            else
            {
                CurrentNode.Next = newNode;
                newNode.Next = FirstNode;
                CurrentNode = newNode;
            }
            Count++;
        }

        /// <summary>
        /// 出圈---num表示数几下
        /// </summary>
        /// <param name="num"></param>
        public void Del(int num = 2)
        {
            SingleLinkNode<T> beforeNode = CurrentNode;
            SingleLinkNode<T> nowNode = FirstNode;

            while (true)
            {
                if (beforeNode == nowNode)
                {
                    FirstNode = nowNode;
                    CurrentNode = nowNode;
                    break;
                }


                for (int i = 0; i < num - 1; i++)
                {
                    nowNode = nowNode.Next;
                    beforeNode = beforeNode.Next;
                }

                nowNode = nowNode.Next;
                beforeNode.Next = nowNode;
                Count--;
            }

        }

        /// <summary>
        /// 打印环形链表
        /// </summary>
        public List<T> Show()
        {
            SingleLinkNode<T> tempNode = FirstNode;
            List<T> lst = new List<T>(Count);
            while (true)
            {
                if (tempNode != null)
                {
                    lst.Add(tempNode.Data);
                    tempNode = tempNode.Next;

                    if (tempNode == FirstNode)
                        break;
                }
            }
            return lst;
        }

        /// <summary>
        /// 链表长度
        /// </summary>
        /// <returns></returns>
        public int Length() => Count;



    }
}
