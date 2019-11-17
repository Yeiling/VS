using System;

namespace 尚硅谷数据结构和算法.Stacks
{
    /// <summary>
    /// 使用数组实现栈---功能
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayStack<T>
    {
        /// <summary>
        /// 对象数组
        /// </summary>
        private T[] Arry { get; set; }
        /// <summary>
        /// 数组的最后一个值的索引
        /// </summary>
        private int Index { get; set; }

        /// <summary>
        /// 构造函数初始化数组
        /// </summary>
        /// <param name="Count"></param>
        public ArrayStack(int Count)
        {
            Arry = new T[Count];
            Index = -1;
        }

        /// <summary>
        /// 栈是否已满
        /// </summary>
        /// <returns></returns>
        public bool IsFull() => Index == Arry.Length - 1;

        /// <summary>
        /// 栈是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Index == -1;

        /// <summary>
        /// 栈---添加
        /// </summary>
        /// <param name="model"></param>
        public void Push(T model)
        {
            if (IsFull())
                throw new Exception("栈已满,不能添加");

            Index++;
            Arry[Index] = model;
        }

        /// <summary>
        /// 栈---删除
        /// </summary>
        public T Pop()
        {
            if (IsEmpty())
                throw new Exception("栈为空，不能删除");

            T result = Arry[Index];
            Arry[Index] = default(T);
            Index--;
            return result;
        }

        //遍历栈---倒叙 for(int i=Index;i>=0;i--){}


    }
}
