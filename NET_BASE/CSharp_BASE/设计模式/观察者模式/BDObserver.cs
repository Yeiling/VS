using System;

namespace CSharp_BASE.设计模式.观察者模式
{
    /// <summary>
    /// 创建观察者---百度网站
    /// </summary>
    public class BDObserver : ObserverInterface
    {
        /// <summary>
        /// 百度网站(观察者)具体实现---接受消息
        /// </summary>
        /// <param name="wd"></param>
        /// <param name="sd"></param>
        /// <param name="qy"></param>
        public void Update(double wd, double sd, double qy)
        {
            Console.WriteLine("百度网获取到了最新消息如下 " + "温度：" + wd + "  湿度：" + sd + "  气压：" + qy);
        }
    }
}
