namespace 数据结构和算法.查找
{
    /// <summary>
    /// 参照算法
    /// </summary>
    public static class Search
    {
        /// <summary>
        /// 二分查找---数组必须是顺序大小[1,2,3,4,5,6,7,8,9]
        /// </summary>
        /// <param name="arry"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int MidSearch(int[] array, int key)
        {
            //指定low和high
            int low = 0, high = array.Length - 1;
            int mid = 0; //折半
            //折半查找
            while (low <= high)
            {
                //求得mid-
                mid = (low + high) / 2;

                //判断是否等于
                if (key == array[mid])
                    return mid;
                else if (key < array[mid])
                    high = mid - 1;
                else //key > array[mid]
                    low = mid + 1;
            }
            return -1;
        }

    }
}
