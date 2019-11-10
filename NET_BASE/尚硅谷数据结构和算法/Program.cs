using System;
using 尚硅谷数据结构和算法.Arry;

namespace 尚硅谷数据结构和算法
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义二维数组的行数和列数
            int row = 11, col = 11;
            SparseArry sparseArry = new SparseArry();
            int[,] arr = sparseArry.CreateArry(row, col);

            //1：展示二维数组
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("  ");
                }
                Console.Write("\r\n");
            }

            Console.WriteLine("----------华丽的分割线----------");

            //2：二维数组转稀疏数组
            int[,] sparsearr = sparseArry.ArryToSparseArr(arr);
            //展示稀疏数组
            for (int k = 0; k < sparsearr.GetLength(0); k++)
            {
                for (int h = 0; h < sparsearr.GetLength(1); h++)
                {
                    Console.Write(sparsearr[k, h]);
                    Console.Write("  ");
                }
                Console.Write("\r\n");
            }

            Console.WriteLine("----------华丽的分割线----------");

            //3：稀疏数组转二维数组
            int[,] arrs = sparseArry.SparseArrToArry(sparsearr);
            //展示二维数组
            for (int m = 0; m < arrs.GetLength(0); m++)
            {
                for (int n = 0; n < arrs.GetLength(1); n++)
                {
                    Console.Write(arrs[m, n]);
                    Console.Write("  ");
                }
                Console.Write("\r\n");
            }


            Console.ReadKey();
        }
    }
}
