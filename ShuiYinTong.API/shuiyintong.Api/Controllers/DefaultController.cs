using Microsoft.AspNetCore.Mvc;
using NLog;
using System;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 测试使用
    /// </summary>
    public class DefaultController : BaseController
    {
        //private Dictionary<string, string> DirData = new Dictionary<string, string>
        //{
        //    { "BorrowingEnterprise","三星电子"}, //借款企业
        //    { "AgreementNumber","20190900110"}, //借款合同编号
        //    { "Loan","1022.52"}, //借款金额         
        //    { "GuaranteedMount","3600.00"},//担保的借款金额为人民币
        //    { "PeriodMonth","36"}, //申请借款的期限月
        //    { "InterestYear","2019"},//起息日
        //    { "AAA","12"},
        //    { "BBB","10"},
        //    { "DueYear","2025"},//到期日
        //    { "CCC","10"},
        //    { "DDD","15"},
        //    { "TotalMoney","4622.52"}
        //};

        ///// <summary>
        ///// 生成Word文档GenerateDoc
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //public void CreateWord(GuaranteeReq guaranteeReq)
        //{
        //    string paths = @"F:\GitHubProject\ShuiYinTong.API\shuiyintong.Api\File\担保函.docx";
        //    NPOIHleper.Export(paths, @"C:\Users\Mypc\Desktop\1.docx", DirData);
        //}


        private readonly Logger nlog = LogManager.GetCurrentClassLogger(); //获得日志实;
        /// <summary>
        /// 日志测试
        /// </summary>
        [HttpGet]
        public void Test()
        {
            try
            {
                int a = 100, b = 0;
                qqq(a, b);
            }
            catch (Exception e)
            {
                nlog.Log(LogLevel.Trace, "Trace");
                nlog.Log(LogLevel.Debug, "Debug");
                nlog.Log(LogLevel.Info, "Info");
                nlog.Log(LogLevel.Warn, "Warn");
                nlog.Log(LogLevel.Error, "Error");
                nlog.Log(LogLevel.Fatal, "Fatal");

                nlog.Trace(e, e.Message);
                nlog.Debug(e, e.Message);
                nlog.Info(e,e.Message);
                nlog.Warn(e, e.Message);
                nlog.Error(e, e.Message);
                nlog.Fatal(e, e.Message);
            }
        }

        private int qqq(int a, int b)
        {
            return a / b;
        }
    }
}