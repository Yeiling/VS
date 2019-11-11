namespace 尚硅谷数据结构和算法.Arry
{
    /// <summary>
    /// 稀疏数组
    /// </summary>
    public class SparseArry
    {
        //稀疏数组是解决二维数组中大量重复的数据，或者没有意义的数据，比如:0，
        //可以起到压缩数组大小的作用
        //说明：棋盘有11*11个格子，0表示没有数据，1表示黑子，2表示篮子

        /// <summary>
        /// 创建二维数组
        /// </summary>
        /// <param name="row">行数</param>
        /// <param name="col">列数</param>
        /// <returns></returns>
        public int[,] CreateArry(int row, int col)
        {
            //ChessArry数组表示有row行col列的二维数组
            int[,] ChessArry = new int[row, col];
            ChessArry[1, 2] = 1; //黑子 第2行第3列为黑子棋
            ChessArry[2, 3] = 2; //蓝子 第3行第4列为蓝子棋
            return ChessArry; //其他都是0，表示没有棋子
        }

        /// <summary>
        /// 二维数组--->稀疏数组也是数组，且只有3列，行数不固定
        /// 第一行第一列表示行数，第一行第二列表示列数，第一行第三列表示有效数字的值
        /// </summary>
        /// <param name="arr">二维数组</param>
        /// <param name="ignoreNum">忽视的数字</param>
        /// <returns></returns>
        public int[,] ArryToSparseArr(int[,] arr, int ignoreNum = 0)
        {
            //int rank = Arry.Rank; //获取维数,row=2表示2维数组，1表示1维数组
            int row = arr.GetLength(0); //表示行数
            int col = arr.GetLength(1); //表示列数

            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (arr[i, j] != ignoreNum)
                        sum++;
                }
            }
            //定义稀疏数组(稀疏数组也是一个二维数组),列数是3不变
            int[,] sparseArr = new int[sum + 1, 3];
            //将二维数组中的有效值放入稀疏数组
            //其中第一列是写死的，第一行第一列表示行数，第一行第二列表示列数，第一行第三列表示有效数字的值
            sparseArr[0, 0] = row;
            sparseArr[0, 1] = col;
            sparseArr[0, 2] = sum;

            int Index = 1; //稀疏数组从第二行开始记录有效数据
            for (int k = 0; k < row; k++)
            {
                for (int h = 0; h < col; h++)
                {
                    if (arr[k, h] != ignoreNum)
                    {
                        sparseArr[Index, 0] = k;
                        sparseArr[Index, 1] = h;
                        sparseArr[Index, 2] = arr[k, h];
                        Index++;
                    }
                }
            }
            return sparseArr;
        }

        /// <summary>
        /// 稀疏数组转二维数组
        /// </summary>
        /// <param name="sparseArr">稀疏数组</param>
        /// <returns></returns>
        public int[,] SparseArrToArry(int[,] sparseArr)
        {
            //定义二维数组
            int[,] arr = new int[sparseArr[0, 0], sparseArr[0, 1]];
            //赋值
            for (int i = 1; i <= sparseArr[0, 2]; i++)
                arr[sparseArr[i, 0], sparseArr[i, 1]] = sparseArr[i, 2];
            return arr;
        }
      

    }
  
}
