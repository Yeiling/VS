using System.Collections;
using System.Text;

namespace 数据结构和算法.栈和队列
{
    public class StackQueue
    {
        //栈和队列不属于数据结构的讲解重点
        //栈和队列都是线性结构(受限制的)

        //栈---先进后出
        //可以用数组或者链表实现

        //队列---先进先出
        //可以用数组或者链表实现---使用链表性能由于使用数组


        //案例：使用栈实现进制转换
        public static string ConvertMod(int num)
        {
            StringBuilder sb = new StringBuilder();
            Stack stack = new Stack();
            if (num > 0)
            {
                int shang = 0;
                while (true)
                {
                    shang = num >> 1;//---6
                    stack.Push(num % 2);
                    num = shang;
                    if (shang == 0)
                        break;
                }
            }
            if (stack.Count > 0)
            {
                while (stack.Count != 0)
                    sb.Append(stack.Pop());
            }
            return sb.ToString();
        }

    }
}
