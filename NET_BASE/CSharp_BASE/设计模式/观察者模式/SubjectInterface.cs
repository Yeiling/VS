namespace CSharp_BASE.设计模式.观察者模式
{
    /// <summary>
    /// 主题接口
    /// </summary>
    public interface SubjectInterface<T>
    {
        /// <summary>
        /// 订阅主题
        /// </summary>
        /// <param name="Observer"></param>
        void RegisterSubject(ObserverInterface<T> Observer);

        /// <summary>
        /// 取消订阅主题
        /// </summary>
        /// <param name="Observer"></param>
        void RemoveSubject(ObserverInterface<T> Observer);

        ///// <summary>
        ///// 发布消息给订阅者---发布通知信息
        ///// </summary>
        ///// <param name="wd"></param>
        ///// <param name="sd"></param>
        ///// <param name="qy"></param>
        //void NotifyObservers(double wd, double sd, double qy);

        /// <summary>
        /// 发布消息给订阅者---发布通知信息
        /// </summary>
        /// <param name="msgModel">消息</param>
        T NotifyObservers(T msgModel);
    }
}
