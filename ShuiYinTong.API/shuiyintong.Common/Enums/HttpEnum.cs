using System.ComponentModel;

namespace shuiyintong.Common.Enums
{
    public class HttpEnum
    {
        /// <summary>
        /// Http请求类型
        /// </summary>
        public enum HttpReqType
        {
            [Description("POST")]
            Post = 0,
            [Description("GET")]
            Get = 1
        }


    }
}
