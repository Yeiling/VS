using System;
using System.Collections.Generic;

namespace 尚硅谷数据结构和算法.LinkLists
{
    /// <summary>
    /// 单链表
    /// </summary>
    public class SingleLinkList<T>
    {
        /// <summary>
        /// 头结点
        /// </summary>
        private SingleLinkNode<T> Header { get; set; }
        /// <summary>
        /// 节点数
        /// </summary>
        private int Count { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public SingleLinkList()
        {
            Header = new SingleLinkNode<T> { Data = default(T), Next = null };
        }

        /// <summary>
        /// 单链表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Count == 0;

        /// <summary>
        /// 单链表添加元素---尾部添加
        /// </summary>
        /// <param name="t"></param>
        public void Add(T t)
        {
            SingleLinkNode<T> newNode = new SingleLinkNode<T> { Data = t, Next = null };
            var currentNode = Header.Next;
            if (currentNode != null)
            {
                while (true)
                {
                    if (currentNode.Next == null)
                    {
                        currentNode.Next = newNode;
                        break;
                    }
                    else
                        currentNode = currentNode.Next;
                }
            }
            else
                Header.Next = newNode;

            Count++;
        }

        /// <summary>
        /// 单链表自定义添加
        /// </summary>
        /// <param name="t"></param>
        /// <param name="func">定义方法</param>
        public void Add(T t, Func<T, T, bool> func)
        {
            if (func == null)
                Add(t);
            else
            {
                SingleLinkNode<T> newNode = new SingleLinkNode<T> { Data = t, Next = null };
                SingleLinkNode<T> CurrentNde = Header.Next;
                SingleLinkNode<T> BeforeCurrentNde = Header;
                if (CurrentNde == null)
                {
                    Header.Next = newNode;
                    Count++;
                }
                else
                {
                    while (true)
                    {
                        if (func(CurrentNde.Data, t))
                        {
                            newNode.Next = CurrentNde;
                            BeforeCurrentNde.Next = newNode;
                            Count++;
                            break;
                        }
                        else
                        {
                            if (CurrentNde.Next != null)
                            {
                                if (func(CurrentNde.Next.Data, t))
                                {
                                    newNode.Next = CurrentNde.Next;
                                    CurrentNde.Next = newNode;
                                    Count++;
                                    break;
                                }
                                else
                                {
                                    BeforeCurrentNde = BeforeCurrentNde.Next;
                                    CurrentNde = CurrentNde.Next;
                                }
                            }
                            else
                            {
                                CurrentNde.Next = newNode;
                                Count++;
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 单链表反转
        /// </summary>
        /// <returns></returns>
        public void Reverse()
        {
            if (Header.Next == null && Header.Next.Next == null)
                return;
            //1:定义一个临时的头结点
            SingleLinkNode<T> ReverseHeader = new SingleLinkNode<T> { Data = default(T), Next = null };
            //2:遍历单链表，将取出的元素放到临时头结点的下面
            SingleLinkNode<T> CurrentNode = Header.Next; //当前节点
            SingleLinkNode<T> CurrentNodeNext = null;   //当前节点的下一个节点
            //3:遍历链表
            while (CurrentNode != null)
            {
                CurrentNodeNext = CurrentNode.Next;
                CurrentNode.Next = ReverseHeader.Next; //当前节点的下一个指向临时头结点的下一个节点
                ReverseHeader.Next = CurrentNode; //临时节点指向当前节点
                CurrentNode = CurrentNodeNext; //向后移动一次
            }
            Header.Next = ReverseHeader.Next;
        }

        /// <summary>
        /// 单链表反转---使用栈
        /// </summary>
        public void ReverseByStack()
        {
            if (Header.Next == null && Header.Next.Next == null)
                return;

            Stack<SingleLinkNode<T>> stack = new Stack<SingleLinkNode<T>>(Count);
            SingleLinkNode<T> Node = Header.Next;
            while (true)
            {
                if (Node != null)
                {
                    stack.Push(Node);
                    Node = Node.Next;
                }
                else
                    break;
            }

            SingleLinkNode<T> temp = Header;
            while (true)
            {
                if (stack.Count == 0)
                    break;
                temp.Next = stack.Pop();
                temp = temp.Next;
            }
        }


    }

}

