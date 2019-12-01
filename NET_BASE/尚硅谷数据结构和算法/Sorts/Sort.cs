using System;

namespace 尚硅谷数据结构和算法.Sorts
{
    /// <summary>
    /// 排序
    /// </summary>
    public class Sort
    {
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arry"></param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] arry, Func<int, int, bool> fun)
        {
            bool flag = false;
            for (int i = 0; i < arry.Length - 1; i++)
            {
                for (int j = 0; j < arry.Length - 1 - i; j++)
                {
                    if (fun(arry[j], arry[j + 1]))
                    {
                        flag = true;
                        arry[j] -= arry[j + 1];
                        arry[j + 1] += arry[j];
                        arry[j] = arry[j + 1] - arry[j];
                    }
                }
                if (!flag)  //表示一次排序没有交换任何位置，数组已经是顺序的了
                    break;
                else
                    flag = false;
            }
            return arry;
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="fun"></param>
        public static void SelectionSort(int[] arr, Func<int, int, bool> fun)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (fun(arr[i], arr[j])) //交换数值
                    {
                        arr[i] -= arr[j];
                        arr[j] += arr[i];
                        arr[i] = arr[j] - arr[i];
                    }
                }
            }
        }

    }
}
