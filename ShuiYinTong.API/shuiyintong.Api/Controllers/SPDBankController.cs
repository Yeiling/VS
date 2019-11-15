using Microsoft.AspNetCore.Mvc;
using shuiyintong.Common;
using shuiyintong.Common.Extend;
using shuiyintong.Common.NPOIFile;
using shuiyintong.DBUtils;
using shuiyintong.Entity.AppSettiongModel;
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
        ///// <summary>
        ///// 数据库实现
        ///// </summary>
        //public IBaseService<AcctDtlInfoQry> AcctDtlInfoServer { get; set; }
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
        /// <summary>
        /// Redis服务
        /// </summary>
        private static readonly NewLifeRedisHelper redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);

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
        [HttpGet]
        public void GenerateDoc(GuaranteeReq guaranteeReq)
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
                           { "AAA",guaranteeReq.InterestDate.Month<10?"0"+guaranteeReq.InterestDate.Month:guaranteeReq.InterestDate.Month.ToString()},
                           { "BBB",guaranteeReq.InterestDate.Day<10?"0"+guaranteeReq.InterestDate.Day:guaranteeReq.InterestDate.Day.ToString()},
                           { "DueYear",guaranteeReq.DueDate.Year.ToString()},//到期日
                           { "CCC",guaranteeReq.DueDate.Month<10?"0"+guaranteeReq.DueDate.Month:guaranteeReq.DueDate.Month.ToString()},
                           { "DDD",guaranteeReq.DueDate.Day<10?"0"+guaranteeReq.DueDate.Day:guaranteeReq.DueDate.Day.ToString()},
                           { "TotalMoney",guaranteeReq.TotalMoney}
                       };
                //var xmlFile = Assembly.GetExecutingAssembly();
                //var path = Path.GetDirectoryName(xmlFile.Location) + "\\担保函.docx";
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
        public JsonResult AcctInfo([FromBody]AccountReq accountRequest)
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
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
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
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 单笔划拨结果查询
        /// </summary>
        /// <param name="snglTrsfRstlQryReq">请求参数</param>
        [HttpPost]
        public string SnglTrsfRstlQry([FromBody]SnglTrsfRstlQryReq snglTrsfRstlQryReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(snglTrsfRstlQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.SnglTrsfRstlQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.SnglTrsfRstlQry + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 电子回单申请
        /// </summary>
        /// <param name="electRecptApplctionReq">请求参数</param>
        [HttpPost]
        public string ElectRecptApplction([FromBody]ElectRecptApplctionReq electRecptApplctionReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(electRecptApplctionReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.ElectRecptApplction, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.ElectRecptApplction + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 三方解约
        /// </summary>
        /// <param name="fncThdCnclReq">请求参数</param>
        [HttpPost]
        public string FncThdCncl([FromBody]FncThdCnclReq fncThdCnclReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(fncThdCnclReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.FncThdCncl, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.FncThdCncl + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 退汇附加信息查询
        /// </summary>
        /// <param name="rexgAddInfoQryReq">请求参数</param>
        [HttpPost]
        public string RexgAddInfoQry([FromBody]RexgAddInfoQryReq rexgAddInfoQryReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(rexgAddInfoQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.RexgAddInfoQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.RexgAddInfoQry + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 根据抹账流水查原往账流水
        /// </summary>
        /// <param name="bnkInfoQryCombntnTranReq">请求参数</param>
        [HttpPost]
        public string BnkInfoQryCombntnTran([FromBody]BnkInfoQryCombntnTranReq bnkInfoQryCombntnTranReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(bnkInfoQryCombntnTranReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.BnkInfoQryCombntnTran, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.BnkInfoQryCombntnTran + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 单笔资金划拨小额鉴权
        /// </summary>
        /// <param name="authSmlAmt">请求参数</param>
        [HttpPost]
        public string AuthSmlAmt([FromBody]AuthSmlAmtReq authSmlAmt)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(authSmlAmt, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.AuthSmlAmt, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.AuthSmlAmt + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 支付指令登记
        /// </summary>
        /// <param name="payInsrChkReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string PayInsrChk([FromBody]PayInsrChkReq payInsrChkReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(payInsrChkReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.PayInsrChk, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.PayInsrChk + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 支付指令明细查询
        /// </summary>
        /// <param name="payInsrDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string PayInsrDtlQry([FromBody]PayInsrDtlQryReq payInsrDtlQryReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(payInsrDtlQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.PayInsrDtlQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.PayInsrDtlQry + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 支付指令取消
        /// </summary>
        /// <param name="payInsrCnlReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string PayInsrCnl([FromBody]PayInsrCnlReq payInsrCnlReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(payInsrCnlReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.PayInsrCnl, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.PayInsrCnl + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 收款人白名单查询
        /// </summary>
        /// <param name="payeeWhtLstQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string PayeeWhtLstQry([FromBody]PayeeWhtLstQryReq payeeWhtLstQryReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(payeeWhtLstQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.PayeeWhtLstQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.PayeeWhtLstQry + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 收款人白名单维护
        /// </summary>
        /// <param name="payeeWhtLstMntnReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string PayeeWhtLstMntn([FromBody]PayeeWhtLstMntnReq payeeWhtLstMntnReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(payeeWhtLstMntnReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.PayeeWhtLstMntn, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.PayeeWhtLstMntn + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        #endregion

        #region e商贷API接口

        /// <summary>
        /// 备付金或结算户转客户结算户
        /// </summary>
        /// <param name="zLSysInrBnkTfrReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string ZLSysInrBnkTfr([FromBody]ZLSysInrBnkTfrReq zLSysInrBnkTfrReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(zLSysInrBnkTfrReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.ZLSysInrBnkTfr, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.ZLSysInrBnkTfr + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 贷款归还
        /// </summary>
        /// <param name="olBrwLnRepyReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string OlBrwLnRepy([FromBody]OlBrwLnRepyReq olBrwLnRepyReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(olBrwLnRepyReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.OlBrwLnRepy, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.OlBrwLnRepy + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 贷款还款明细查询
        /// </summary>
        /// <param name="intDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string IntDtlQry([FromBody]IntDtlQryReq intDtlQryReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(intDtlQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.IntDtlQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.IntDtlQry + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 贷款试算
        /// </summary>
        /// <param name="interestTrialReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string InterestTrial([FromBody]InterestTrialReq interestTrialReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(interestTrialReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.InterestTrial, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.InterestTrial + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 电子回单申请
        /// </summary>
        /// <param name="receiptApplyReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string ReceiptApply([FromBody]ReceiptApplyReq receiptApplyReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(receiptApplyReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.ReceiptApply, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.ReceiptApply + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 对公贷款还款维护
        /// </summary>
        /// <param name="corpLnCntlAcctReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string CorpLnCntlAcctRep([FromBody]CorpLnCntlAcctReq corpLnCntlAcctReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(corpLnCntlAcctReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.CorpLnCntlAcctRep, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.CorpLnCntlAcctRep + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 归还贷款本金利息试算
        /// </summary>
        /// <param name="olBrwLnRepyTrlReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string OlBrwLnRepyTrl([FromBody]OlBrwLnRepyTrlReq olBrwLnRepyTrlReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(olBrwLnRepyTrlReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.OlBrwLnRepyTrl, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.OlBrwLnRepyTrl + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 还款查询
        /// </summary>
        /// <param name="coreTranQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string CoreTranQry([FromBody]CoreTranQryReq coreTranQryReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(coreTranQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.CoreTranQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.CoreTranQry + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 划拨结果查询
        /// </summary>
        /// <param name="zLSysBussBkQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string ZLSysBussBkQry([FromBody]ZLSysBussBkQryReq zLSysBussBkQryReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(zLSysBussBkQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.ZLSysBussBkQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.ZLSysBussBkQry + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 借据详细信息查看
        /// </summary>
        /// <param name="lnRcrdDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string LnRcrdDtlQry([FromBody]LnRcrdDtlQryReq lnRcrdDtlQryReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(lnRcrdDtlQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.LnRcrdDtlQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.LnRcrdDtlQry + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 借据应还本金利息查询
        /// </summary>
        /// <param name="corpAgngLnRcvblntQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string CorpAgngLnRcvblntQry([FromBody]CorpAgngLnRcvblntQryReq corpAgngLnRcvblntQryReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(corpAgngLnRcvblntQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.CorpAgngLnRcvblntQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.CorpAgngLnRcvblntQry + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        /// <summary>
        /// 已放贷款还款计划查询
        /// </summary>
        /// <param name="crpLnIntTrlReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string CrpLnIntTrl([FromBody]CrpLnIntTrlReq crpLnIntTrlReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            var header = GetHeaderSign(crpLnIntTrlReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.CrpLnIntTrl, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result;
                baseResponse.ResponseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;

                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.CrpLnIntTrl + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return baseResponse.ToJson();
        }

        #endregion

    }
}
