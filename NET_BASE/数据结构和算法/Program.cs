using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using 数据结构和算法.Model;

namespace 数据结构和算法
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------数据结构------------------
            //1:逻辑结构---线性结构，非线性结构
            //2:存储结构---顺序存储，链式存储，散列存储，索引存储
            //3:数据的运算---检索，添加，删除，排序等操作

            //-----------------------算法----------------------
            //算法:时间复杂度和空间复杂度


            #region 数组
            //int[] arry = new int[] { 3, 7, 1, 5, 8 };
            //1：数组添加一个元素
            //int[] newarry = new int[arry.Length + 1];
            //for (int i = 0; i < arry.Length; i++)
            //{
            //    newarry[i] = arry[i];
            //}
            //newarry[newarry.Length - 1] = 100;
            //Console.WriteLine(ArryForeach(newarry));

            //var narry = ArryAddOneItem(arry, 100, 6);
            //var strarry = ArryAddOneItem(new string[] { "天下", "中国", "虾米", "情怀", "强者" }, "奋斗", 5);
            //var trmp = RemoveOneItemByIndex(strarry, 6);

            //2：数组移除一个元素
            //RemoveOneItemByIndex(arry, 2);
            #endregion

            #region 查找算法
            //int[] arry = new int[] { 3, 7, 1, 5, 8 };
            //1:线性查找
            //for (int i = 0; i < arry.Length; i++)
            //{
            //    if (arry[i] == 5)
            //    {
            //        Console.WriteLine(arry[i]);
            //    }
            //}
            //2:二分法查找数据---局限于顺序的数组
            //int[] arrys = new int[] { 5, 10, 39, 55, 71, 89, 100 };
            //bool isExists;
            //var index = EFind(arrys, 71, out isExists);
            #endregion

            #region 栈数据操作
            //定义一个栈对象-- - 可以定义栈的长度，超过则自动扩容
            //Stack<int> stack = new Stack<int>(3);
            //int num = 0;
            //Random r = new Random();
            //while (num < 10)
            //{
            //    stack.Push(r.Next(0, 101));
            //    num++;
            //}
            //int top = stack.Peek();//查看栈顶元素
            //while (true)
            //{
            //    if (stack.Count == 0)
            //        break;
            //    stack.Pop();
            //}
            #endregion

            #region 队列
            //Queue<int> queue = new Queue<int>(3);
            //int num = 0;
            //Random r = new Random();
            //while (num < 10)
            //{
            //    queue.Enqueue(r.Next(0, 101));
            //    num++;
            //}
            //int top = queue.Peek(); // 查看队首元素
            //while (true)
            //{
            //    if (queue.Count == 0)
            //        break;

            //    queue.Dequeue();
            //}
            #endregion

            #region 双向链表
            //LinkedList<int> link = new LinkedList<int>();
            //int num = 0;
            //Random r = new Random();
            //while (num < 10)
            //{
            //    link.AddFirst(r.Next(0, 101));
            //    num++;
            //}

            //var firstNode = link.First; // 查看链表第一个节点
            //var lastNode = link.Last;// 查看链表最后一个节点
            //var firstData = firstNode.Value; //查看链表第一个节点的值
            //var lastData = lastNode.Value; // 查看链表最后一个节点的值

            //while (true)
            //{
            //    if (link.Count == 0)
            //        break;

            //    link.RemoveLast();
            //}
            #endregion

            #region 线性结构---相关操作
            //Arry myArry = new Arry();
            //Arry.Add(3);
            //Arry.Add(6);
            //Arry.Add(1);
            //Arry.Add(4);
            //Arry.Add(5);
            //Arry.Add(0, 8);
            //Arry.Add(-9, 2);
            //Arry.Add(9, 12);
            //Arry.Add(3, 15);
            //int len = Arry.Length; //数组长度
            //int count = Arry.Count; //元素个数
            #endregion

            #region 单链表---相关操作



            #endregion









            Console.ReadKey();
        }

        #region 数组相关方法
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

        /// <summary>
        /// 二分法查找元素
        /// </summary>
        /// <param name="arry">数组</param>
        /// <param name="item">元素</param>
        /// <returns>元素位置索引</returns>
        private static int EFind(int[] arry, int item, out bool IsExist)
        {
            //起始元素位置，结束元素位置，中间位置
            int beginIndex = 0, endIndex = arry.Length - 1, middleIndex = (beginIndex + endIndex) / 2;
            IsExist = false;
            while (true)
            {
                if (arry[middleIndex] == item)
                {
                    IsExist = true;
                    return middleIndex;
                }
                else
                {
                    if (middleIndex == arry.Length - 1)
                        return -1;
                    if (arry[middleIndex] > item)
                        endIndex = middleIndex - 1;
                    else
                        beginIndex = middleIndex + 1;

                    middleIndex = (beginIndex + endIndex) / 2;
                }
            }
        }
        #endregion

        #region 栈--操作

        #endregion
    }
}
