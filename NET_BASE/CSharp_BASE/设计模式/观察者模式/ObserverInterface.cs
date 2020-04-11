namespace CSharp_BASE.设计模式.观察者模式
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface ObserverInterface
    {
        /// <summary>
        /// 更新数据信息
        /// </summary>
        /// <param name="wd">温度</param>
        /// <param name="sd">湿度</param>
        /// <param name="qy">气压</param>
        void Update(double wd, double sd, double qy);

    }
}
