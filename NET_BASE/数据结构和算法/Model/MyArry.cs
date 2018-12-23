using System;
using 数据结构和算法.CommonInterface;

namespace 数据结构和算法.Model
{
    public class MyArry : IMyInterface<object>
    {
        /// <summary>
        /// object数组
        /// </summary>
        public object[] Arrys { get; set; }
        /// <summary>
        /// 索引位置
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 数组的默认长度10
        /// </summary>
        private static int Default { get; } = 5;

        /// <summary>
        /// 获取数组长度
        /// </summary>
        public int Length => Arrys.Length;

        #region 构造函数
        /// <summary>
        /// 默认初始化是10个长度
        /// </summary>
        public MyArry() : this(Default)
        {
        }
        public MyArry(int num)
        {
            Arrys = new object[num];
        }
        #endregion

        #region 数组自动扩容方法
        /// <summary>
        /// 数组扩容
        /// </summary>
        /// <param name="Multiple">扩容倍数</param>
        /// <returns>返回扩容之后的数组</returns>
        private object[] ArrysExp(int Multiple = 2)
        {
            object[] newArry = null;
            if (Multiple >= 2)
                newArry = new object[Arrys.Length * Multiple];
            for (int i = 0; i < Arrys.Length; i++)
            {
                newArry[i] = Arrys[i];
            }
            return newArry;
        }
        #endregion

        #region 接口方法实现
        public void Add(object t)
        {
            if (Arrys.Length == Index)
                Arrys = ArrysExp();

            Arrys[Index++] = t;
        }

        public void Add(object t, int index)
        {
            if (Arrys.Length == Index)
                Arrys = ArrysExp();

           
        }

        public bool Contains(object t)
        {
            throw new NotImplementedException();
        }

        public object Get(int index)
        {
            if (index < 0 || index > Arrys.Length - 1)
                return null;
            else
                return Arrys[index];
        }

        public int Indexof(object t)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            if (Index >= 0)
                return true;
            else
                return false;
        }

        public void Remove(object t)
        {
            throw new NotImplementedException();
        }

        public void Remove(object t, int index)
        {
            throw new NotImplementedException();
        }

        public object Replace(int index, object newModel)
        {
            Arrys[index] = newModel;
            return newModel;
        }
        #endregion
    }
}