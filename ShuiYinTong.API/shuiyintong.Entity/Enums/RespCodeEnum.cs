
using System.ComponentModel;

namespace shuiyintong.Entity.Enums
{
    public class RespCodeEnum
    {
        /// <summary>
        /// Http请求结果定义枚举类型
        /// </summary>
        public enum ResponseType
        {
            [Description("失败")]
            Fail = 0,
            [Description("成功")]
            Success = 1,

        }
    }
}
