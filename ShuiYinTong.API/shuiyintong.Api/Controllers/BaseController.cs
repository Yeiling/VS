using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using shuiyintong.Common.BankConfig;

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
        public BankConfig bankConfig { get; } = AppSettings.BankConfig;
    }


}
