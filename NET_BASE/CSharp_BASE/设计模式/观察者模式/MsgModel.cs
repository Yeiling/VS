namespace CSharp_BASE.设计模式.观察者模式
{
    /// <summary>
    /// 消息结构
    /// </summary>
    public class MsgModel
    {
        /// <summary>
        /// 温度
        /// </summary>
        public double Wd { get; set; }
        /// <summary>
        /// 湿度
        /// </summary>
        public double Sd { get; set; }
        /// <summary>
        /// 气压
        /// </summary>
        public double Qy { get; set; }
    }
}
