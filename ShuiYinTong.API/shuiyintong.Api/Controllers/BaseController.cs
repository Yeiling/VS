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
    }


}
