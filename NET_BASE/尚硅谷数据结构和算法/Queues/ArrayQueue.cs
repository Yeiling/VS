using System;

namespace 尚硅谷数据结构和算法.Queues
{
    /// <summary>
    /// 数组模拟队列---静态的队列，明显布斯和并发和多线程不安全
    /// </summary>
    public class ArrayQueue
    {
        /// <summary>
        /// 数组对象
        /// </summary>
        private int[] Arr;
        /// <summary>
        /// 队列最大长度
        /// </summary>
        private int MaxSize;
        /// <summary>
        /// 对首数据索引
        /// </summary>
        private int Front;
        /// <summary>
        /// 队尾数据索引
        /// </summary>
        private int Rear;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="length"></param>
        public ArrayQueue(int length)
        {
            MaxSize = length;
            Arr = new int[MaxSize];
            Front = -1;
            Rear = -1;
        }

        /// <summary>
        /// 队列是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Front == Rear;

        /// <summary>
        /// 队列是否已满
        /// </summary>
        /// <returns></returns>
        public bool IsFull() => Rear == MaxSize - 1;

        /// <summary>
        /// 入队列
        /// </summary>
        /// <param name="num"></param>
        public void Add(int num)
        {
            //队列未满
            if (!IsFull())
                Arr[Rear++] = num;
            else
                throw new Exception("队列已满");
        }

        /// <summary>
        /// 出队列
        /// </summary>
        public int Del()
        {
            if (!IsEmpty())
                return Arr[Front++];
            else
                throw new Exception("队列已满");
        }


    }
}
