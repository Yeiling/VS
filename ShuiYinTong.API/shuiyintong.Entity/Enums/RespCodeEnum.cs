using System.ComponentModel;

namespace shuiyintong.Entity.Enums
{
    /// <summary>
    /// Http返回状态码
    /// </summary>
    public class RespCodeEnum
    {
        /// <summary>
        /// Http请求结果定义枚举类型
        /// </summary>
        public enum ResponseType
        {
            /// <summary>
            /// 请求失败
            /// </summary>
            [Description("失败")]
            Fail = 0,
            /// <summary>
            /// 请求成功
            /// </summary>
            [Description("成功")]
            Success = 1,

        }
    }
}
