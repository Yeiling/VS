using Microsoft.AspNetCore.Mvc;

namespace GoodOrderService.Controllers
{
    /// <summary>
    /// 服务健康检查
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        /// <summary>
        /// 健康检查
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();  //返回HttpStatusCode=200
        }
    }
}