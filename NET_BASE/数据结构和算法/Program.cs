using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using 数据结构和算法.单链表;
using 数据结构和算法.双链表;
using 数据结构和算法.查找;
using 数据结构和算法.栈和队列;
using 数据结构和算法.树;
using 数据结构和算法.集合.Model;

namespace 数据结构和算法
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ForEach函数可以改变对象，只有当对象为String时不能改变
            //List<person> people = new List<person>
            //{
            //    new person{ name="ahi",age=28,sex='男'},
            //    new person{ name="giauhdjh",age=22,sex='女'},
            //    new person{ name="zccdop",age=20,sex='女'},
            //    new person{ name="pxo",age=24,sex='男'},
            //    new person{ name="zhongkai",age=21,sex='男'}
            //};
            //people.ForEach(p =>
            //{
            //    if (p.name.Contains('h'))
            //        p.age = 100;
            //});
            #endregion

            //---------------------数据结构------------------
            //1:逻辑结构---线性结构，非线性结构
            //2:存储结构---顺序存储，链式存储，散列存储，索引存储
            //3:数据的运算---检索，添加，删除，排序等操作

            //-----------------------算法--------------------
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

            #region 自定义栈---数据结构和算法
            //使用双链表实现栈
            //LinkStack<int> stack = new LinkStack<int>();
            //stack.Push(2);
            //stack.Push(6);
            //stack.Push(5);
            //stack.Push(8);
            //stack.Push(3);
            //var zd = stack.Peek();
            //stack.Pop();
            //zd = stack.Peek();
            //var str = stack.ToString();
            //var bol = stack.IsEmpty();
            //var arry = stack.ToArry();

            //使用双链表实现队列
            //LinkQueue<int> linkQueue = new LinkQueue<int>();
            //linkQueue.EnQueue(5);
            //linkQueue.DeQueue();
            //linkQueue.EnQueue(3);
            //linkQueue.EnQueue(1);
            //linkQueue.EnQueue(5);
            //var a = linkQueue.IsEmpty();
            //var first = linkQueue.FirstQueueElement();
            //var str = linkQueue.ToString();
            //var arr = linkQueue.ToArry();

            //LinkStack<int> stack = new LinkStack<int>();
            //LinkQueue<int> linkQueue = new LinkQueue<int>();
            //Random r = new Random();
            //int rdm = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    rdm = r.Next(0, 1000);
            //    stack.Push(rdm);
            //    linkQueue.EnQueue(rdm);
            //}
            //var ls = stack.ToString();
            //var lq = linkQueue.ToString();
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

            //var resultss = StackQueue.ConvertMod(13);
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

            #region 双向链表---net自带
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

            #region 单链表---模拟相关操作
            //SingLinkList<int> singLinkList = new SingLinkList<int>();
            //singLinkList.Add(88);
            //singLinkList.Add(16);
            //singLinkList.Add(1, 101);
            //singLinkList.Add(0, 2);
            //singLinkList.Add(7);
            //singLinkList.Add(55);
            //singLinkList.Remove(2);
            //singLinkList.Replace(1, 100);
            //var num = singLinkList.Get(3);
            //var b = singLinkList.Contains(7);
            //Console.WriteLine(singLinkList.ToString());
            //Console.WriteLine(singLinkList.Get(2).Data);
            #endregion

            #region 双链表---模拟相关操作
            //MultLinkList<int> multLinkList = new MultLinkList<int>();
            //multLinkList.Add(99);
            //multLinkList.Add(5);
            //multLinkList.Add(2);
            //multLinkList.Add(7);
            //multLinkList.Add(8);
            //multLinkList.Add(3);
            //multLinkList.Remove(3);
            //var t = multLinkList.Get(2);
            //Console.WriteLine(multLinkList.ToString());
            #endregion

            #region 树---二叉树
            //创建一个完整的二叉树
            TreeNode<int> node5 = new TreeNode<int>(5);
            TreeNode<int> node4 = new TreeNode<int>(4, null, node5);

            TreeNode<int> node7 = new TreeNode<int>(7);
            TreeNode<int> node6 = new TreeNode<int>(6, null, node7);
            TreeNode<int> node3 = new TreeNode<int>(3);
            TreeNode<int> node2 = new TreeNode<int>(2, node3, node6);

            TreeNode<int> node1 = new TreeNode<int>(1, node4, node2);

            //构建二叉树
            LinkTree<int> tree = new LinkTree<int>(node1);

            //先序---根--左--右 1,4,5,2,3,6,7
            Queue<int> queue1 = new Queue<int>();
            var result = tree.PreOrderTree(ref queue1);

            Queue<int> queue2 = new Queue<int>();
            result = tree.PreOrderTreeExt(ref queue2);

            //中序---左--根--右 4,5,1,3,2,6,7
            Queue<int> queue3 = new Queue<int>();
            result = tree.InOrderTree(ref queue3);

            //后序---左--右--根 4,5,3,2,6,7,1
            Queue<int> queue4 = new Queue<int>();
            result = tree.PostOrderTree(ref queue4);

            int height = tree.Height();
            var num = tree.Count;

            #endregion

            #region 查找
            //二分法查找---顺序存储结构数组必须是有序的,即:从小到大
            //int[] arry = { 6, 21, 41, 51, 5, 67, 87, 99, 100 };    
            //int index = Search.MidSearch(arry, 300);
            #endregion

            #region 栈和队列
            //Stack stack = new Stack();  //栈---先进后出
            //Queue queue = new Queue();  //队列---先进先出
            #endregion

            #region 快速排序
            //int[] array = { 49, 38, 65, 97, 76, 13, 27 };
            //Sort.QuickSort(array, 0, array.Length - 1);
            #endregion

            #region 选择排序
            //int[] arr = new int[] { 49, 38, 65, 97, 76, 13, 27, -3 };
            //Sort.SelectionSort(arr, false);
            #endregion

            #region 冒泡排序
            //int[] arr = new int[] { 49, 38, 65, 97, 76, 13, 27, -3 };
            //Sort.BubbleSort(arr,false);
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

    }

    /// <summary>
    /// 测试类
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public char Sex { get; set; }
    }
}
