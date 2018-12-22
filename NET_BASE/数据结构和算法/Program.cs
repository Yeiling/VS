using System;
using System.Collections.Generic;
using System.Text;

namespace 数据结构和算法
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------算法-----------------

            #region 数组
            int[] arry = new int[] { 3, 7, 1, 5, 8 };
            //1：数组添加一个元素
            //int[] newarry = new int[arry.Length + 1];
            //for (int i = 0; i < arry.Length; i++)
            //{
            //    newarry[i] = arry[i];
            //}
            //newarry[newarry.Length - 1] = 100;
            //Console.WriteLine(ArryForeach(newarry));

            //var narry = ArryAddOneItem(arry, 100, 6);
            var strarry = ArryAddOneItem(new string[] { "天下", "中国", "虾米", "情怀", "强者" }, "奋斗", 5);

            var trmp = RemoveOneItemByIndex(strarry, 6);

            #endregion
            //2：数组移除一个元素
            int[] newarry1 = new int[arry.Length - 1];



            Console.ReadKey();
        }

        /// <summary>
        /// 查看数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arry"></param>
        /// <returns></returns>
        private static string ArryForeach<T>(T[] arry)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arry.Length; i++)
            {
                sb.Append(arry[i] + ",");
            }
            return sb.ToString().TrimEnd(',');
        }

        /// <summary>
        /// 数组添加一个元素到数组的指定位置
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arry"></param>
        /// <param name="t"></param>
        /// <param name="index">元素要添加的位置，从0开始到数组长度-1</param>
        /// <returns></returns>
        private static T[] ArryAddOneItem<T>(T[] arry, T t, int index)
        {
            T[] newarry = new T[arry.Length + 1];
            if (index <= 0) //添加到数组的头部
            {
                newarry[0] = t;
                for (int i = 0; i < arry.Length; i++)
                {
                    newarry[i + 1] = arry[i];
                }
            }
            else
            {
                if (index <= arry.Length) //添加到数组指定的位置
                {
                    for (int j = 0; j < newarry.Length; j++)
                    {
                        if (j < index - 1)
                            newarry[j] = arry[j];
                        else if (j == index - 1)
                            newarry[j] = t;
                        else
                            newarry[j] = arry[j - 1];
                    }
                }
                else  //添加到数组的末尾
                {
                    for (int i = 0; i < arry.Length; i++)
                    {
                        newarry[i] = arry[i];
                    }
                    newarry[arry.Length] = t;
                }
            }
            return newarry;
        }

        /// <summary>
        /// 数组按照索引位置，删除一个数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arry"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static T[] RemoveOneItemByIndex<T>(T[] arry, int index)
        {
            if (index > 0 && index <= arry.Length)
            {
                T[] newarry = new T[arry.Length - 1];//新数组
                for (int i = 0; i < arry.Length - 1; i++)
                {
                    if (i >= index - 1)
                        newarry[i] = arry[i + 1];
                    else
                        newarry[i] = arry[i];
                }
                return newarry;
            }
            else
                return arry;
        }

      
    }
}
