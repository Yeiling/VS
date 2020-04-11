using System;

namespace CSharp_BASE.设计模式.观察者模式
{
    /// <summary>
    /// 创建观察者---百度网站
    /// </summary>
    public class BDObserver<T> : ObserverInterface<T>
    {
        /// <summary>
        /// 百度网站(观察者)具体实现---接受消息
        /// </summary>
        /// <param name="wd"></param>
        /// <param name="sd"></param>
        /// <param name="qy"></param>
        public T Update(T msaModel)
        {
            return msaModel;
        }
    }
}
