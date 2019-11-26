using Microsoft.AspNetCore.Mvc;
using shuiyintong.DBUtils.IService;
using shuiyintong.DBUtils.LinuxTestEntity;
using shuiyintong.Entity.LogEntity;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 日志信息
    /// </summary>
    public class NLogController : BaseController
    {
        /// <summary>
        /// 日志
        /// </summary>
        public IBaseService<bank_nlog> LogServer { get; set; }

        /// <summary>
        /// 查看所有日志信息
        /// </summary>
        /// <param name="logQueryReq">日志</param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult QueryLog(LogQueryReq logQueryReq)
        {
            var logs = LogServer.Queryable()
                      .Where(l => l.STATUS == logQueryReq.Status)
                      .Where(l => l.Logged >= logQueryReq.LoggedFrom && l.Logged <= logQueryReq.LoggedEnd)
                      .WhereIF(!string.IsNullOrEmpty(logQueryReq.BankName), it => it.BankName.Contains(logQueryReq.BankName))
                      .WhereIF(!string.IsNullOrEmpty(logQueryReq.CtrName), it => it.Controller.Contains(logQueryReq.CtrName))
                      .WhereIF(!string.IsNullOrEmpty(logQueryReq.ActName), it => it.Action.Contains(logQueryReq.ActName))
                      .ToList();

            return Json(logs);
        }

    }
}