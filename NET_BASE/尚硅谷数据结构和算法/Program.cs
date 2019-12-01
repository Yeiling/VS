using System;
using System.Collections;
using 尚硅谷数据结构和算法.Kmp;
using 尚硅谷数据结构和算法.LinkLists;
using 尚硅谷数据结构和算法.Resoursion;
using 尚硅谷数据结构和算法.Sorts;
using 尚硅谷数据结构和算法.Stacks;

namespace 尚硅谷数据结构和算法
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 二维数组和稀疏数组转换
            ////定义二维数组的行数和列数
            //int row = 11, col = 11;
            //SparseArry sparseArry = new SparseArry();
            //int[,] arr = sparseArry.CreateArry(row, col);

            ////1：展示二维数组
            //for (int i = 0; i < 11; i++)
            //{
            //    for (int j = 0; j < 11; j++)
            //    {
            //        Console.Write(arr[i, j]);
            //        Console.Write("  ");
            //    }
            //    Console.Write("\r\n");
            //}

            //Console.WriteLine("----------华丽的分割线----------");

            ////2：二维数组转稀疏数组
            //int[,] sparsearr = sparseArry.ArryToSparseArr(arr);
            ////展示稀疏数组
            //for (int k = 0; k < sparsearr.GetLength(0); k++)
            //{
            //    for (int h = 0; h < sparsearr.GetLength(1); h++)
            //    {
            //        Console.Write(sparsearr[k, h]);
            //        Console.Write("  ");
            //    }
            //    Console.Write("\r\n");
            //}

            //Console.WriteLine("----------华丽的分割线----------");

            ////3：稀疏数组转二维数组
            //int[,] arrs = sparseArry.SparseArrToArry(sparsearr);
            ////展示二维数组
            //for (int m = 0; m < arrs.GetLength(0); m++)
            //{
            //    for (int n = 0; n < arrs.GetLength(1); n++)
            //    {
            //        Console.Write(arrs[m, n]);
            //        Console.Write("  ");
            //    }
            //    Console.Write("\r\n");
            //} 
            #endregion

            #region 双链表
            //DoubleLinkList<int> myLinkList = new DoubleLinkList<int>();
            //int i = 0;
            //Random r = new Random();
            //int tempData = 0;
            //while (i < 10)
            //{
            //    tempData = r.Next(0, 11);
            //    myLinkList.Add(tempData);
            //    i++;
            //} 
            #endregion

            #region 单链表
            //SingleLinkList<int> singleLinkList = new SingleLinkList<int>();
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    var num = r.Next(1, 10);
            //    //singleLinkList.Add(num);
            //    singleLinkList.Add(num, (a, b) => { return a > b; });
            //}

            //singleLinkList.Reverse();

            #endregion

            #region 栈
            //ArrayStack<int> arrayStack = new ArrayStack<int>(10);
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int num = r.Next(1, 30);
            //    arrayStack.Push(num);
            //}

            //for (int j = 0; j < 10; j++)
            //{
            //    var tt = arrayStack.Pop();
            //}


            #endregion

            #region 环形链表实现约瑟夫环
            //创建环形链表
            //CircleList<int> circleList = new CircleList<int>();

            //circleList.Add(2);
            //circleList.Add(6);
            //circleList.Add(1);
            //circleList.Add(7);
            //circleList.Add(9);

            ////报数出列
            //var lst = circleList.Show();
            //circleList.Del(2);

            #endregion

            #region 栈(net自带栈)实现混合运算
            //string str = "5+2*6-7*2+1";
            //Stack numStack = new Stack();
            //Stack fhStack = new Stack();
            //for (int i = 0; i < str.Length; i++)
            //{

            //}


            #endregion

            #region 迷宫问题
            ////创建二维数组
            //int[,] arry = MiGong.CreateArry(8, 8);
            ////设置最外围一圈为1，表示不可以遍历
            //for (int i = 0; i < 8; i++)
            //{
            //    //0行和7行赋值1
            //    arry[0, i] = 1;
            //    arry[7, i] = 1;
            //    //0列和7列赋值1
            //    arry[i, 0] = 1;
            //    arry[i, 7] = 1;
            //}

            //打印二维数组地图
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(arry[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            //MiGong.GetWay2(arry, 1, 1, 4, 3);
            ////打印二维数组地图
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(arry[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 暴力匹配和KMP---字符串匹配
            //string str1 = "ABCABBB";
            //string str2 = "CA";
            //int index = StrKmp.VoildMath(str1, str2);

            #endregion

            #region 排序
            int[] arry = new int[] { 6, 3, -1, 9, 7, 2 };
            arry = Sort.BubbleSort(arry, (before, after) => before - after > 0);
            arry = Sort.BubbleSort(arry, (before, after) => before - after < 0);




            #endregion

            Console.ReadKey();
        }
    }
}
