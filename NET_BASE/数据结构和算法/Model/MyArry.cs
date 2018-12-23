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
        /// 索引位置---元素的个数
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 数组的默认长度10
        /// </summary>
        private static int Default { get; } = 5;

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
        public int Length => Arrys.Length;
        public void Add(object t)
        {
            if (Arrys.Length == Index)
                Arrys = ArrysExp();

            Arrys[Index++] = t;
        }

        public void Add(object t, int index)
        {
            if (Arrys.Length == Index)
                Arrys = ArrysExp();  //数组扩容
            if (index <= 0) //添加到数组的头部
            {
                for (int i = Index; i > 0; i--)
                    Arrys[i] = Arrys[i - 1];
                Arrys[0] = t;
            }
            else
            {
                if (index <= Index) //添加到数组指定的位置
                {
                    for (int j = Index; j > 0; j--)
                    {
                        if (j > index - 1)
                            Arrys[j] = Arrys[j - 1];
                        else if (j == index - 1)
                            Arrys[j] = t;
                    }
                }
                else  //添加到数组的末尾                 
                    Arrys[Index] = t;
            }
            Index++;
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