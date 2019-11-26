using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using shuiyintong.Entity.AppSettiongModel;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 控制器基类
    /// </summary>
    [EnableCors("any")]
    [Route("[controller]/[action]")]
    public class BaseController : Controller
    {
        /// <summary>
        /// 银行配置
        /// </summary>
        public static BankConfig bankConfig = AppSettings.BankConfig;
        /// <summary>
        /// Redis链接字符串
        /// </summary>
        public static string RedisConn = AppSettings.RedisConfig.RedisConn;
        /// <summary>
        /// 数据库链接字符串
        /// </summary>
        public static string DBConn = AppSettings.DBConfig.DBConn;
    }


}
