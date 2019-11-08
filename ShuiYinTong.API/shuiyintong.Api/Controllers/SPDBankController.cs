using Microsoft.AspNetCore.Mvc;
using shuiyintong.Common;
using shuiyintong.Common.BankConfig;
using shuiyintong.Common.Extend;
using shuiyintong.Common.NPOIFile;
using shuiyintong.DBUtils;
using shuiyintong.DBUtils.IService;
using shuiyintong.DBUtils.SYT_apiDB_TestEntity;
using shuiyintong.Entity;
using shuiyintong.Entity.HttpRequestResultEntity;
using shuiyintong.Entity.SPDBankEntity.SPDBankFile;
using shuiyintong.Entity.SPDBankEntity.SPDBankReq;
using shuiyintong.SPDB;
using System;
using System.Collections.Generic;
using System.IO;
using static shuiyintong.Entity.Enums.BankTypeEum;
using static shuiyintong.Entity.Enums.RedisDBEnum;
using static shuiyintong.Entity.Enums.RespCodeEnum;
using static shuiyintong.Entity.SPDBankEntity.SPDBankAPITypeEunm;
using WTPC_ERR = shuiyintong.Entity.SPDBankEntity.SPDBankFile.WTPC_ERR;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 浦发银行接口
    /// </summary>
    public class SPDBankController : BaseController
    {
        /// <summary>
        /// 数据库实现
        /// </summary>
        public IBaseService<AcctDtlInfoQry> AcctDtlInfoServer { get; set; }
        //public IBaseService<DVR_USER_LOGIN_INFO> DVR_USER_LOGIN_INFO { get; set; }


        /// <summary>
        /// 银行类型---浦发银行
        /// </summary>
        private readonly BankType SPDBank = BankType.SPDBank;
        /// <summary>
        /// 浦发银行配合信息
        /// </summary>
        private readonly SPDBankConfig SPDBankConfig = bankConfig.SPDBankConfig;
        /// <summary>
        /// Http请求返回Code
        /// </summary>
        private readonly int Code = 200;
        ///// <summary>
        ///// NLog日志记录对象
        ///// </summary>
        //private readonly Logger nlog = LogManager.GetCurrentClassLogger(); //获得日志实例;
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

        #region 生成担保函
        /// <summary>
        /// 担保函导出Word文档
        /// </summary>
        /// <param name="guaranteeReq">参数---输出路径必填</param>
        [HttpPost]
        public void GenerateDoc([FromBody]GuaranteeReq guaranteeReq)
        {
            if (guaranteeReq != null && !string.IsNullOrWhiteSpace(guaranteeReq.OutPath))
            {
                var DirData = new Dictionary<string, string>
                       {
                           { "BorrowingEnterprise",guaranteeReq.BorrowingEnterprise}, //借款企业
                           { "AgreementNumber",guaranteeReq.AgreementNumber}, //借款合同编号
                           { "Loan",guaranteeReq.Loan}, //借款金额         
                           { "GuaranteedMount",guaranteeReq.GuaranteedMount},//担保的借款金额为人民币
                           { "PeriodMonth",guaranteeReq.PeriodMonth}, //申请借款的期限月
                           { "InterestYear",guaranteeReq.InterestDate.Year.ToString()},//起息日
                           { "AAA",guaranteeReq.InterestDate.Month.ToString()},
                           { "BBB",guaranteeReq.InterestDate.Day.ToString()},
                           { "DueYear",guaranteeReq.DueDate.Year.ToString()},//到期日
                           { "CCC",guaranteeReq.DueDate.Month.ToString()},
                           { "DDD",guaranteeReq.DueDate.Day.ToString()},
                           { "TotalMoney",guaranteeReq.TotalMoney}
                       };
                var path = Directory.GetCurrentDirectory() + "\\File\\担保函.docx";
                NPOIHleper.Export(path, guaranteeReq.OutPath, DirData);
            }
        }
        #endregion

        #region 文件上传下载
        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="upLoadReq">请求参数</param>
        [HttpPost]
        public string UpLoadfile([FromBody]SPDBankFileUpLoadReq upLoadReq)
        {
            if (upLoadReq != null)
            {
                WTPC_ERR tPC_ERR = new WTPC_ERR();
                bool b = SPDBankFile.UpLoadfile(upLoadReq.localFile, upLoadReq.remoteFile, upLoadReq.remotedir, upLoadReq.transId, upLoadReq.transFlag, ref tPC_ERR);
                if (b)
                    return tPC_ERR.ToJson();
            }

            return null;
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="downLoadReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string DownLoadfile([FromBody]SPDBankFileDownLoadReq downLoadReq)
        {
            if (downLoadReq != null)
            {
                WTPC_ERR tPC_ERR = new WTPC_ERR();
                bool b = SPDBankFile.DownLoadfile(downLoadReq.remoteFile, downLoadReq.localFile, downLoadReq.localdir, downLoadReq.transId, downLoadReq.transFlag, downLoadReq.taskid, ref tPC_ERR);
                if (b)
                    return tPC_ERR.ToJson();
            }
            return null;
        }
        #endregion


        #region e账通标准API接口

        /// <summary>
        /// 获取账户信息
        /// </summary>
        /// <param name="accountRequest">请求参数</param>
        [HttpPost]
        public string AcctInfo([FromBody]AccountReq accountRequest)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");        
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(accountRequest, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.AcctInfo, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.AcctInfo + "-" + Now + "-" + baseResponse.ResponseType;
                var redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 查询账户信息
        /// </summary>
        /// <param name="acctInfoReq">请求参数</param>
        [HttpPost]
        public string AcctDtlInfoQry([FromBody]AcctDtlInfoQryReq acctInfoReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(acctInfoReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.AcctDtlInfoQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.AcctDtlInfoQry + "-" + Now + "-" + baseResponse.ResponseType;
                var redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 单笔划拨
        /// </summary>
        /// <param name="singleTransferReq">请求参数</param>
        [HttpPost]
        public string SingleTransfer([FromBody]SingleTransferReq singleTransferReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(singleTransferReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.SingleTransfer, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.SingleTransfer + "-" + Now + "-" + baseResponse.ResponseType;
                var redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        #endregion

    }
}
