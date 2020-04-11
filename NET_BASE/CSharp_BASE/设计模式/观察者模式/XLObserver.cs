using System;

namespace CSharp_BASE.设计模式.观察者模式
{
    /// <summary>
    /// 创建一个观察者-新浪网站，实现观察者接口
    /// </summary>
    public class XLObserver : ObserverInterface
    {
        /// <summary>
        /// 新浪网站(观察者)具体实现---接受消息
        /// </summary>
        /// <param name="wd"></param>
        /// <param name="sd"></param>
        /// <param name="qy"></param>
        public void Update(double wd, double sd, double qy)
        {
            Console.WriteLine("新浪网获取到了最新消息如下 " + "温度：" + wd + "  湿度：" + sd + "  气压：" + qy);
        }
    }
}
