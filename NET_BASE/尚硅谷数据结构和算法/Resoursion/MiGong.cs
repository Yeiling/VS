namespace 尚硅谷数据结构和算法.Resoursion
{
    /// <summary>
    /// 迷宫问题
    /// </summary>
    public class MiGong
    {
        /// <summary>
        /// 创建二维数组
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int[,] CreateArry(int x, int y) => new int[x, y];

        /// <summary>
        /// 递归搜索路径 行走规则：下--->右--->上--->左
        /// </summary>
        /// <param name="arry">二维数组</param>
        /// <param name="x">X轴坐标</param>
        /// <param name="y">Y轴坐标</param>
        /// <param name="a">要找的X轴坐标</param>
        /// <param name="b">要找的Y轴坐标</param>
        /// <returns></returns>
        public static bool GetWay1(int[,] arry, int x, int y, int a, int b)
        {
            if (arry[a, b] == 2) //表示已找到
                return true;
            else
            {
                if (arry[x, y] == 0) //当前节点没有走过
                {
                    arry[x, y] = 2;  //标记已经走过，防止重复走
                    //行走规则：下--->右--->上--->左
                    if (GetWay1(arry, x, y - 1, a, b)) //向下走
                        return true;
                    else if (GetWay1(arry, x + 1, y, a, b)) //向右走
                        return true;
                    else if (GetWay1(arry, x, y + 1, a, b)) //向上走
                        return true;
                    else if (GetWay1(arry, x - 1, y, a, b)) //向上走
                        return true;
                    else  //该节点走不通，是死路
                    {
                        arry[x, y] = 3;
                        return false;
                    }
                }
                else
                    return false;
            }
        }

        /// <summary>
        /// 递归搜索路径 行走规则：斜线---最短距离
        /// </summary>
        /// <param name="arry"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool GetWay2(int[,] arry, int x, int y, int a, int b)
        {
            if (arry[a, b] == 2) //表示已找到
                return true;
            else
            {
                if (arry[x, y] == 0) //当前节点没有走过
                {
                    arry[x, y] = 2;  //标记已经走过，防止重复走
                    //行走规则：下--->右--->上--->左
                    if (a > x)
                    {
                        if (b > y)
                        {
                            if (GetWay2(arry, x + 1, y + 1, a, b))
                                return true;
                        }
                        else if (b < y)
                        {
                            if (GetWay2(arry, x + 1, y - 1, a, b))
                                return true;
                        }
                        else
                        {
                            if (GetWay2(arry, x + 1, y, a, b))
                                return true;
                        }
                    }
                    else if (a < x)
                    {
                        if (b > y)
                        {
                            if (GetWay2(arry, x - 1, y + 1, a, b))
                                return true;
                        }
                        else if (b < y)
                        {
                            if (GetWay2(arry, x - 1, y - 1, a, b))
                                return true;
                        }
                        else
                        {
                            if (GetWay2(arry, x - 1, y, a, b))
                                return true;
                        }
                    }
                    else
                    {
                        if (b > y)
                        {
                            if (GetWay2(arry, x, y + 1, a, b))
                                return true;
                        }
                        else if (b < y)
                        {
                            if (GetWay2(arry, x, y - 1, a, b))
                                return true;
                        }
                        else
                        {
                            if (GetWay2(arry, x, y, a, b))
                                return true;
                        }
                    }
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
