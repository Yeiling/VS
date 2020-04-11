using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_BASE.设计模式
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {
        #region 饿汉式写法---优点：线程安全 缺点：内存浪费
        //private static Singleton singleton = new Singleton();
        //private Singleton() { }
        ///// <summary>
        ///// 对外暴露一个初始化方法
        ///// </summary>
        ///// <returns></returns>
        //public static Singleton GetSingleton()
        //{
        //    return singleton;
        //}
        #endregion

        #region 懒汉式写法---优点： 缺点：
        private static Singleton singleton;
        private Singleton()
        {
        }

        /// <summary>
        /// 对外暴露一个初始化方法
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSingleton()
        {
            if (singleton == null)
                singleton = new Singleton();
            return singleton;
        }
        #endregion

    }
}
