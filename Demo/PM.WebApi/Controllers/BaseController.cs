using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace PM.WebApi.Controllers
{
    /// <summary>
    /// 控制器基类
    /// </summary>
    [Route("api/[controller]/[action]")]
    [EnableCors("any")]  //Ajax跨域
    [ApiController]
    public class BaseController : Controller
    {
    }
}