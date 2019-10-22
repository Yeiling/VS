using System.ComponentModel;

namespace shuiyintong.Entity.Enums
{
    public class RedisDBEnum
    {
        public enum RedisDbNum
        {
            [Description("返回数据")]
            RespDb = 1,
            [Description("异常日志")]
            ErrorDb = 2
        }
    }
}
