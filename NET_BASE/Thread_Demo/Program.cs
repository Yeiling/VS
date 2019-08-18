using System;

namespace Thread_Demo
{
    class Program
    {
        public enum xq   //枚举
        {
            monday = 1,
            sunday = 0
        }
        //Main方法是程序入口,也是程序的主线程
        static void Main(string[] args)
        {
            //创建线程实例带有一个无参数无返回值的方法,---此处使用直接定义的匿名函数

            //线程默认是前台线程,所有的前台线程都退出,进程才退出;
            //后台线程不会阻塞进程的退出;
            #region 线程1---重载(无参数线程)
            //Thread th = new Thread(delegate()
            //{
            //    while (true)
            //    {
            //        Console.WriteLine(DateTime.Now);
            //        Thread.Sleep(100);
            //    }
            //});
            //th.IsBackground = true;   //将线程设置成后台线程,默认是false(前台线程)
            //th.Start();

            //th.Join();  ////让一个线程等待另一线程终结后再继续运行
            //th.Abort();  ////不得已才能用,强制终止线程,容易报异常

            //Console.ReadKey();
            #endregion

            #region 线程2---重载(有参数的线程)
            //Thread t = new Thread((s) =>
            //{
            //    Console.WriteLine(s);
            //});
            //t.Start("123");  //参数是object类型,可以传递任意类型参数
            #endregion

            #region 线程池(静态)--线程池的线程本身是后台线程,线程池线程可以重用,提高利用率
            //ThreadPool.QueueUserWorkItem(s =>
            //{
            //    Console.WriteLine("ssss");
            //});
            #endregion

            //能用线程池就用线程池,处理顺序不确定,适合(大批量的)小运算
            //需要线程执行大量运算时,手动创建
            //当想手动关闭线程时,手动创建线程
            //需要规定线程的优先级时,手动创建线程


            //进程---查看计算机的所有进程(也可以关闭或者打开一个进程)
            #region 查看计算机的进程
            //Process[] ps = Process.GetProcesses();
            //foreach (Process p in ps)
            //{
            //    Console.WriteLine(p);
            //    //Process.Start(参数);
            //}
            #endregion

            //带参数的线程
            //Thread th = new Thread(s =>
            //{
            //    Console.WriteLine(s);
            //});
            //th.Start("1231");





            Console.ReadKey();
        }

        static void Pth(string s)
        {
            Console.WriteLine(s);
        }
    }
}
