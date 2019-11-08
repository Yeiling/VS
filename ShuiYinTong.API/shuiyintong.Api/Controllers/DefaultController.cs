using Microsoft.AspNetCore.Mvc;
using NLog;
using shuiyintong.Common;
using shuiyintong.Common.BankConfig;
using shuiyintong.Common.Extend;
using shuiyintong.Entity.HttpRequestResultEntity;
using shuiyintong.Entity.SPDBankEntity.SPDBankReq;
using shuiyintong.SPDB;
using System;
using System.Collections.Generic;
using static shuiyintong.Entity.Enums.RespCodeEnum;
using static shuiyintong.Entity.SPDBankEntity.SPDBankAPITypeEunm;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 测试使用
    /// </summary>
    public class DefaultController : BaseController
    {
        /// <summary>
        /// 获得日志实例
        /// </summary>
        private readonly Logger nlog = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 浦发银行配合信息
        /// </summary>
        private readonly SPDBankConfig SPDBankConfig = bankConfig.SPDBankConfig;
        /// <summary>
        /// Http请求返回Code
        /// </summary>
        private readonly int Code = 200;



        /// <summary>
        /// 单笔划拨--日志测试
        /// </summary>
        /// <param name="singleTransferReq">请求参数</param>
        [HttpPost]
        public void SingleTransfer([FromBody]SingleTransferReq singleTransferReq)
        {
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.SingleTransfer;
            int BankAPIType = (int)sPDBankAPIType;
            int code = 0; //http请求错误码
            byte responseType; //返回类型

            try
            {
                var header = GetHeaderSign(singleTransferReq, out string dataRequest);
                HttpClientHelper.POSTRequest(SPDBankConfig.SingleTransfer, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    responseType = (byte)ResponseType.Success;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };
                });
            }
            catch (Exception ex)
            {
                nlog.Error(ex.Message);
            }

        }

        #region 接口签名
        /// <summary>
        /// 获取签名
        /// </summary>
        /// <param name="obj">对象参数</param>
        /// <param name="dataRequest">请求Json字符串</param>
        /// <returns></returns>
        private Dictionary<string, string> GetHeaderSign(object obj, out string dataRequest)
        {
            dataRequest = obj.ToJson();
            var SignMsg = SPDBSignature.Sign(dataRequest, bankConfig.SPDBankConfig.Secret);
            return new Dictionary<string, string>
                {
                        { "X-SPDB-Client-Id", bankConfig.SPDBankConfig.ClientId },
                        { "X-SPDB-SIGNATURE", SignMsg }
                };
        }
        #endregion


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



        ///// <summary>
        ///// 日志测试
        ///// </summary>
        //[HttpGet]
        //public void Test()
        //{
        //    try
        //    {
        //        int a = 100, b = 0;
        //        qqq(a, b);
        //    }
        //    catch (Exception e)
        //    {
        //        nlog.Log(LogLevel.Trace, "Trace");
        //        nlog.Log(LogLevel.Debug, "Debug");
        //        nlog.Log(LogLevel.Info, "Info");
        //        nlog.Log(LogLevel.Warn, "Warn");
        //        nlog.Log(LogLevel.Error, "Error");
        //        nlog.Log(LogLevel.Fatal, "Fatal");

        //        nlog.Trace(e, e.Message);
        //        nlog.Debug(e, e.Message);
        //        nlog.Info(e,e.Message);
        //        nlog.Warn(e, e.Message);
        //        nlog.Error(e, e.Message);
        //        nlog.Fatal(e, e.Message);
        //    }
        //}

        //private int qqq(int a, int b)
        //{
        //    return a / b;
        //}
    }
}