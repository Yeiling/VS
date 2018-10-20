using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NET_BASE.Class
{
    public class SingleClass
    {
        private static SingleClass sc = new SingleClass();
        private SingleClass()  //默认的构造方法私有---private
        { }

        /// <summary>
        /// 写一个public共有方法，提供实例化对象
        /// </summary>
        /// <returns></returns>
        public static SingleClass getSingleClass()
        {
            return SingleClass.sc;
        }


       

    }
}
