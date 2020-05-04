using System.ComponentModel;

namespace WebClient.AchieveFile
{
    /// <summary>
    /// 错误码
    /// </summary>
    public class ErrorCode
    {
        /// <summary>
        /// 错误码列举
        /// </summary>
        public enum HttpCode
        {
            [Description("成功")]
            OK = 200,
            [Description("失败")]
            Failed = 500,



        }
    }
}
