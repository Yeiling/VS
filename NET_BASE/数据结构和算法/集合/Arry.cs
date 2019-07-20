using System;
using 数据结构和算法.CommonInterface;

namespace 数据结构和算法.集合.Model
{
    /// <summary>
    /// 使用数组实现顺序存储
    /// </summary>
    public class Arry<T> : IMyInterface<T>
    {
        #region 之前写法注释掉
        #region 属性字段
        ///// <summary>
        ///// object数组
        ///// </summary>
        //public object[] Arrys { get; set; }
        ///// <summary>
        ///// 索引位置---元素的个数
        ///// </summary>
        //public int Index { get; set; }
        ///// <summary>
        ///// 数组的默认长度10
        ///// </summary>
        //private static int Default { get; } = 5; 
        #endregion

        #region 构造函数
        ///// <summary>
        ///// 默认初始化是10个长度
        ///// </summary>
        //public Arry() : this(Default)
        //{
        //}
        //public Arry(int num)
        //{
        //    Arrys = new object[num];
        //}
        #endregion

        #region 数组自动扩容方法
        ///// <summary>
        ///// 数组扩容
        ///// </summary>
        ///// <param name="Multiple">扩容倍数</param>
        ///// <returns>返回扩容之后的数组</returns>
        //private object[] ArrysExp(int Multiple = 2)
        //{
        //    object[] newArry = null;
        //    if (Multiple >= 2)
        //        newArry = new object[Arrys.Length * Multiple];
        //    for (int i = 0; i < Arrys.Length; i++)
        //    {
        //        newArry[i] = Arrys[i];
        //    }
        //    return newArry;
        //}
        #endregion

        #region 接口方法实现
        //public int Length => Arrys.Length; //数组长度
        //public int Count => Index; //数组元素个数
        ///// <summary>
        ///// 添加元素
        ///// </summary>
        ///// <param name="t">新元素</param>
        //public void Add(object t)
        //{
        //    if (Arrys.Length == Index)
        //        Arrys = ArrysExp();

        //    Arrys[Index++] = t;
        //}
        ///// <summary>
        ///// 制定位置添加元素
        ///// </summary>
        ///// <param name="index">索引位置</param>
        ///// <param name="t">新元素</param>
        //public void Add(int index, object t)
        //{
        //    if (Arrys.Length == Index)
        //        Arrys = ArrysExp();  //扩容
        //    if (index <= 0) //添加到头部
        //    {
        //        for (int i = Index; i > 0; i--)
        //            Arrys[i] = Arrys[i - 1];
        //        Arrys[0] = t;
        //    }
        //    else
        //    {
        //        if (index <= Index) //添加到指定的位置
        //        {
        //            for (int j = Index; j > 0; j--)
        //            {
        //                if (j > index - 1)
        //                    Arrys[j] = Arrys[j - 1];
        //                else if (j == index - 1)
        //                    Arrys[j] = t;
        //            }
        //        }
        //        else  //添加到末尾                 
        //            Arrys[Index] = t;
        //    }
        //    Index++;
        //}
        ///// <summary>
        ///// 是否含有元素
        ///// </summary>
        ///// <param name="t">元素</param>
        ///// <returns>是否包含</returns>
        //public bool Contains(object t) => throw new NotImplementedException();
        ///// <summary>
        ///// 依据索引查找元素
        ///// </summary>
        ///// <param name="index">索引位置</param>
        ///// <returns>目标元素</returns>
        //public object Get(int index)
        //{
        //    if (index < 0 || index > Arrys.Length - 1)
        //        return null;
        //    else
        //        return Arrys[index];
        //}
        ///// <summary>
        ///// 元素的位置
        ///// </summary>
        ///// <param name="t">元素</param>
        ///// <returns>索引位置</returns>
        //public int Indexof(object t) => throw new NotImplementedException();
        ///// <summary>
        ///// 数组是否为空
        ///// </summary>
        ///// <returns>是否为空</returns>
        //public bool IsEmpty()
        //{
        //    if (Index >= 0)
        //        return true;
        //    else
        //        return false;
        //}
        ///// <summary>
        ///// 移除一个元素
        ///// </summary>
        ///// <param name="t">移除目标元素</param>
        //public void Remove(object t) => throw new NotImplementedException();
        ///// <summary>
        ///// 移除一个元素(依据索引)
        ///// </summary>
        ///// <param name="index">索引位置</param>
        //public void Remove(int index) => Arrys[index] = null;
        ///// <summary>
        ///// 替换元素
        ///// </summary>
        ///// <param name="index">索引位置</param>
        ///// <param name="newModel">新元素</param>
        ///// <returns>返回新元素</returns>
        //public object Replace(int index, object newModel)
        //{
        //    Arrys[index] = newModel;
        //    return newModel;
        //}      
        #endregion 
        #endregion

        /// <summary>
        /// 数组对象
        /// </summary>
        private T[] ArrayModel { get; set; }
        /// <summary>
        /// 当前索引位置
        /// </summary>
        private int Index { get; set; }
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
        /// <param name="t"></param>
        public void Add(T t)
        {
            if (Index >= ArrayModel.Length) //扩容数组
                ArrayModel = EnsureArray(ArrayModel);

            ArrayModel[Index++] = t;
        }

        public void Add(int index, T t)
        {
            //if (index < 0 || index > ArrayModel.Length - 1)
            //    throw new Exception("数组索引越界异常" + index);
            //else
            //{
            //    if ()
            //    {
            //    }
            //    ArrayModel[index] = t;
            //}

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

        public int Indexof(T t)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Count == 0;
        /// <summary>
        /// 移除一个数据项
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            if (index < 0 || index > Count)
                return;
            if (index > 0 && index < Count)
            {

            }
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
            {
                newArry[i] = arry[i];
            }
            return newArry;
        }
        #endregion
    }
}