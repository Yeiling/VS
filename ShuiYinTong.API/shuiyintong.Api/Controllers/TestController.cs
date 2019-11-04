using Microsoft.AspNetCore.Mvc;
using shuiyintong.Common.Extend;
using shuiyintong.DBUtils.IService;
using shuiyintong.DBUtils.SYT_apiDB_TestEntity;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 测试使用
    /// </summary>
    public class TestController : BaseController
    {
        /// <summary>
        /// AcctDtlInfoServer
        /// </summary>
        public IBaseService<AcctDtlInfoQry> AcctDtlInfoServer { get; set; }

        /// <summary>
        /// 测试方法
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string AAA()
        {
            var result = AcctDtlInfoServer.GetList(r => true);
            return result.ToJson();
        }
    }
}