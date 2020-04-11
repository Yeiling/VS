using System.Collections.Generic;
using System.Linq;

namespace CSharp_BASE.设计模式.观察者模式
{
    /// <summary>
    /// 主题接口实现
    /// </summary>
    public class SubjectServer : SubjectInterface
    {
        /// <summary>
        /// 观察者接口实现对象集合
        /// </summary>
        public List<ObserverInterface> ObserList { get; set; }

        /// <summary>
        /// 构造函数初始化-观察者接口实现对象集合
        /// </summary>
        public SubjectServer()
        {
            ObserList = new List<ObserverInterface>();
        }

        /// <summary>
        /// 注册/订阅主题
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public void RegisterSubject(ObserverInterface o)
        {
            if (!ObserList.Contains(o))
                ObserList.Add(o);
        }

        /// <summary>
        /// 取消订阅主题
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public void RemoveSubject(ObserverInterface o)
        {
            if (ObserList.Contains(o))
                ObserList.Remove(o);
        }

        /// <summary>
        /// 发布消息给订阅者---发布通知信息
        /// </summary>
        /// <param name="wd">温度</param>
        /// <param name="sd">湿度</param>
        /// <param name="qy">气压</param>
        public void NotifyObservers(double wd, double sd, double qy)
        {
            if (ObserList != null && ObserList.Count() > 0)
            {
                foreach (var obser in ObserList)
                    obser.Update(wd, sd, qy);
            }
        }


    }
}
