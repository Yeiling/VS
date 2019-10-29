using System.ComponentModel;

namespace shuiyintong.Entity.Enums
{
    /// <summary>
    ///  Redis库编号枚举
    /// </summary>
    public class RedisDBEnum
    {
        /// <summary>
        /// 库编号枚举
        /// </summary>
        public enum RedisDbNum
        {
            /// <summary>
            /// 返回数据库
            /// </summary>
            [Description("返回数据库")]
            RespDb = 1,
            /// <summary>
            /// 异常日志库
            /// </summary>
            [Description("异常日志库")]
            ErrorDb = 2
        }
    }
}
