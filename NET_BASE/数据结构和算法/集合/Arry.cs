using System;
using 数据结构和算法.CommonInterface;

namespace 数据结构和算法.集合.Model
{
    /// <summary>
    /// 使用数组实现顺序存储
    /// </summary>
    public class Arry<T> : IMyInterface<T>
    {
        /// <summary>
        /// 数组对象
        /// </summary>
        private T[] ArrayModel { get; set; }
        /// <summary>
        /// 当前索引位置
        /// </summary>
        private int Index { get; set; }
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="indx"></param>
        /// <returns></returns>
        public T this[int indx] => ArrayModel[indx];
        /// <summary>
        /// 初始化数组大小
        /// </summary>
        private byte _initNum = 3;
        public Arry()
        {
            ArrayModel = new T[_initNum];
            Index = 0;  //初始化索引为0
        }
        /// <summary>
        /// 数组长度
        /// </summary>
        public int Length => ArrayModel.Length;
        /// <summary>
        /// 数组共有几个元素
        /// </summary>
        public int Count => Index;
        /// <summary>
        /// 添加一个元素,默认是在数组末尾添加
        /// </summary>
        /// <param name="t">元素</param>
        public void Add(T t) => Add(Index, t);
        /// <summary>
        /// 在指定位置新增一个元素
        /// </summary>
        /// <param name="index">索引位置</param>
        /// <param name="t">元素</param>
        public void Add(int index, T t)
        {
            if (Index == ArrayModel.Length)
                ArrayModel = EnsureArray(ArrayModel);  //扩容

            if (index < 0 || index > Index)
                throw new Exception("数组索引越界异常" + index);
            else
            {
                if (index == Index)
                    ArrayModel[Index++] = t;
                else if (index < Index)
                {
                    for (int i = Index; i > index; i--)
                        ArrayModel[i] = ArrayModel[i - 1];

                    ArrayModel[Index++] = t;
                }
            }
        }
        /// <summary>
        /// 获取索引位置的数据
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            if (index < 0 || index > ArrayModel.Length - 1)
                throw new Exception("索引越界异常" + index);

            return ArrayModel[index];
        }

        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Count == 0;

        public void Remove()
        {
            ArrayModel[Index - 1] = default(T);
            Index--;
        }

        /// <summary>
        /// 移除一个数据项
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            if (index < 0 || index > Index)
                return;
            if (index > 0 && index < Index)
            {
                for (int i = index; i < Index; i++)
                    ArrayModel[index] = ArrayModel[index + 1];

                Index--;
            }
        }
        /// <summary>
        /// 元素索引位置
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Indexof(T t)
        {
            throw new NotImplementedException();
        }
        public void Replace(int index, T newModel)
        {
            if (index < 0 || index > Count)
                return;

            ArrayModel[index] = newModel;
        }


        #region 数组扩容
        /// <summary>
        /// 数组长度自动扩容
        /// </summary>
        /// <param name="arry">型数组</param>
        /// <returns></returns>
        private T[] EnsureArray(T[] arry)
        {
            T[] newArry = new T[arry.Length + (arry.Length >> 1)];
            for (int i = 0; i < arry.Length; i++)
                newArry[i] = arry[i];

            return newArry;
        }
        #endregion
    }
}