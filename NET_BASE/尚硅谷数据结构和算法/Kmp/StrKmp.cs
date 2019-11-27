namespace 尚硅谷数据结构和算法.Kmp
{
    /// <summary>
    /// KMP算法---字符串匹配
    /// </summary>
    public class StrKmp
    {
        /// <summary>
        /// KMP算法匹配字符串
        /// </summary>
        /// <param name="str1">目标字符串</param>
        /// <param name="str2">要匹配的字符串</param>
        /// <returns>位置索引</returns>
        public static int KmpMath(string str1, string str2)
        {
            return -1;
        }

        /// <summary>
        /// 暴力匹配
        /// </summary>
        /// <param name="str1">目标字符串</param>
        /// <param name="str2">要匹配的字符串</param>
        /// <returns>位置索引</returns>
        public static int VoildMath(string str1, string str2)
        {
            if (str1.Length < str2.Length)
                return -1;

            int i = 0, j = 0;
            while (i < str1.Length && j < str2.Length)
            {
                if (str1[i] == str2[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    i = i - j + 1;
                    j = 0;
                }
            }
            return j == str2.Length ? i - j : -1;
        }
    }
}
