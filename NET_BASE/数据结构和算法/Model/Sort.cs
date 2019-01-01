namespace 数据结构和算法.Model
{
    public class Sort
    {
        #region 快速排序
        /// <summary>
        /// 一次排序单元，完成此方法，key左边都比key小，key右边都比key大。
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        private static int SortUnit(int[] array, int low, int high)
        {
            int key = array[low];
            while (low < high)
            {
                /*从后向前搜索比key小的值*/
                while (array[high] >= key && high > low)
                    --high;
                /*比key小的放左边*/
                array[low] = array[high];
                /*从前向后搜索比key大的值，比key大的放右边*/
                while (array[low] <= key && high > low)
                    ++low;
                /*比key大的放右边*/
                array[high] = array[low];
            }
            /*左边都比key小，右边都比key大。//将key放在游标当前位置。//此时low等于high */
            array[low] = key;
            return high;
        }
        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void QuickSort(int[] array, int low, int high)
        {
            if (low >= high)
                return;
            /*完成一次单元排序*/
            int index = SortUnit(array, low, high);
            /*对左边单元进行排序*/
            QuickSort(array, low, index - 1);
            /*对右边单元进行排序*/
            QuickSort(array, index + 1, high);
        }
        #endregion

        #region 冒泡排序
        public static void BullleSort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                #region 将大的数字移到数组的arr.Length-1-i
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
                #endregion
            }
        }
        #endregion

        #region 选择排序
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j]) //交换数值
                    {
                        arr[i] -= arr[j];
                        arr[j] += arr[i];
                        arr[i] = arr[j] - arr[i];
                    }
                }
            }
        }
        public static void SelectionSort(int[] arr, bool SmallToLarge = true)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (SmallToLarge)
                    {
                        if (arr[i] > arr[j]) //交换数值
                        {
                            arr[i] -= arr[j];
                            arr[j] += arr[i];
                            arr[i] = arr[j] - arr[i];
                        }
                    }
                    else
                    {
                        if (arr[i] < arr[j]) //交换数值
                        {
                            arr[i] -= arr[j];
                            arr[j] += arr[i];
                            arr[i] = arr[j] - arr[i];
                        }
                    }
                }
            }
        }
        #endregion

        #region 冒泡排序
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        arr[j] -= arr[j + 1];
                        arr[j + 1] += arr[j];
                        arr[j] = arr[j + 1] - arr[j];
                    }
                }
            }
        }
        public static void BubbleSort(int[] arr, bool SmallToLarge = true)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (SmallToLarge)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            arr[j] -= arr[j + 1];
                            arr[j + 1] += arr[j];
                            arr[j] = arr[j + 1] - arr[j];
                        }
                    }
                    else
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            arr[j] -= arr[j + 1];
                            arr[j + 1] += arr[j];
                            arr[j] = arr[j + 1] - arr[j];
                        }
                    }
                }
            }
        }
        #endregion
    }
}