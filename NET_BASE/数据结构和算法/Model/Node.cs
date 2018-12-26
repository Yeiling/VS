using System;
using System.Collections.Generic;
using System.Text;

namespace 数据结构和算法.Model
{
    /// <summary>
    /// 单链表实现
    /// </summary>
    public class Node
    {
        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 节点指针
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        private Node() { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="data">只有数据，没有节点的链表</param>
        public Node(object data) : this(data, null)
        {
            Data = data;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="node">节点指针</param>
        public Node(object data, Node node)
        {
            Data = data;
            Head = node;
        }

    }
}
