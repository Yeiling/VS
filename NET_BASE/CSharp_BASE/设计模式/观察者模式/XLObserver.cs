using System;

namespace CSharp_BASE.设计模式.观察者模式
{
    /// <summary>
    /// 创建一个观察者-新浪网站，实现观察者接口
    /// </summary>
    public class XLObserver<T> : ObserverInterface<T>
    {
        /// <summary>
        /// 新浪网站(观察者)具体实现---接受/更新消息
        /// </summary>
        /// <param name="wd"></param>
        /// <param name="sd"></param>
        /// <param name="qy"></param>
        public T Update(T msgModel)
        {
            return msgModel;
        }
    }



}
