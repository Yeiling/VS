﻿namespace 数据结构和算法.单链表
{
    /// <summary>
    /// 单链表节点---只有后继，没有前驱
    /// </summary>
    public class Node<T>
    {
        #region 属性
        /// <summary>
        /// 数据
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 节点指针
        /// </summary>
        public Node<T> Next { get; set; }
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
        public Node(T data) : this(data, null)
        {
            Data = data;
        }
        /// <summary>
        /// 构造函数---数据节点
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="node">节点指针</param>
        public Node(T data, Node<T> node)
        {
            Data = data;
            Next = node;
        }
        #endregion

    }
}