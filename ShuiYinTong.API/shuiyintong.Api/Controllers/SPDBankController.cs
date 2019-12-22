using Microsoft.AspNetCore.Mvc;
using shuiyintong.Common;
using shuiyintong.Common.Extend;
using shuiyintong.Common.NPOIFile;
using shuiyintong.DBUtils.IService;
using shuiyintong.Entity.AppSettiongModel;
using shuiyintong.Entity.HttpRequestResultEntity;
using shuiyintong.Entity.SPDBankEntity.SPDBankFile;
using shuiyintong.Entity.SPDBankEntity.SPDBankReq;
using shuiyintong.Entity.SPDBankEntity.SPDBankResp;
using shuiyintong.Entity.SPDBankEntity.SPDResp;
using shuiyintong.SPDB;
using System;
using System.Collections.Generic;
using System.IO;
using static shuiyintong.Entity.Enums.BankTypeEum;
using static shuiyintong.Entity.Enums.RespCodeEnum;
using static shuiyintong.Entity.SPDBankEntity.SPDBankAPITypeEunm;
using WTPC_ERR = shuiyintong.Entity.SPDBankEntity.SPDBankFile.WTPC_ERR;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 浦发银行接口(平台--->>>浦发银行)
    /// </summary>
    public class SPDBankController : BaseController
    {
        #region 银行配置缓存

        /// <summary>
        /// 银行类型---浦发银行
        /// </summary>
        private readonly BankType SPDBank = BankType.SPDBank;
        /// <summary>
        /// 浦发银行配合信息
        /// </summary>
        private readonly SPDBankConfig SPDBankConfig = AppSettings.BankConfig.SPDBankConfig;
        /// <summary>
        /// Http请求返回Code
        /// </summary>
        private readonly int Code = 200;

        #endregion

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
            var SignMsg = SPDBSignature.Sign(dataRequest, SPDBankConfig.Secret);
            return new Dictionary<string, string>
                {
                        { "X-SPDB-Client-Id", SPDBankConfig.ClientId },
                        { "X-SPDB-SIGNATURE", SignMsg }
                };
        }
        #endregion

        #region 生成担保函
        /// <summary>
        /// 担保函导出Word文档----------------------------------------生成担保函----------------------------------------
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
                var path = AppDomain.CurrentDomain.BaseDirectory + "File\\担保函.docx";
                NPOIHleper.Export(path, guaranteeReq.OutPath, DirData);
            }
        }
        #endregion

        #region 文件上传下载
        /// <summary>
        /// 文件上传---扩展测试----------------------------------------文件上传下载开始----------------------------------------
        /// </summary>
        /// <param name="file">文件参数</param>
        /// <returns></returns>
        [HttpPost]
        public string UpLoadfileExt(SPDBankFileUpLoadReqExt file)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "UpLoadFile\\";
            if (!System.IO.File.Exists(path))
                System.IO.File.Create(path);

            DirectoryInfo dir = new DirectoryInfo(path);
            FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
            DirectoryInfo subdir = null;
            foreach (FileSystemInfo i in fileinfo)
            {
                if (i is DirectoryInfo)            //判断是否文件夹
                {
                    subdir = new DirectoryInfo(i.FullName);
                    subdir.Delete(true);          //删除子目录和文件
                }
                else
                    //如果 使用了 streamreader 在删除前 必须先关闭流 ，否则无法删除 sr.close();
                    System.IO.File.Delete(i.FullName);      //删除指定文件
            }

            WTPC_ERR tPC_ERR = new WTPC_ERR();
            bool b = false;
            var stream = file.localFile.OpenReadStream();
            // 把 Stream 转换成 byte[] 
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            //设置当前流的位置为流的开始 
            stream.Seek(0, SeekOrigin.Begin);
            // 把 byte[] 写入文件 
            using (FileStream fs = new FileStream(path + file.localFile.FileName, FileMode.OpenOrCreate))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(bytes);
                bw.Close();

                b = SPDBankFile.UpLoadfile(path + file.localFile.FileName, file.remoteFile, file.remotedir, file.transId, file.transFlag, ref tPC_ERR);
                if (b)
                    return tPC_ERR.ToJson();
                return null;
            }
        }

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
        /// 文件下载------------------------------------------------------------文件上传下载结束----------------------------------------
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
        /// 账户信息查询----------------------------------------e账通标准API接口开始----------------------------------------
        /// </summary>
        /// <param name="accountRequest">请求参数</param>
        [HttpPost]
        public BaseResponse<AccountResp> AcctInfo([FromBody]AccountReq accountRequest)
        {
            BaseResponse<AccountResp> baseResponse = new BaseResponse<AccountResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(accountRequest, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.AcctInfo, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<AccountResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 账户明细信息查询
        /// </summary>
        /// <param name="acctInfoReq">请求参数</param>
        [HttpPost]
        public BaseResponse<AcctDtlInfoQryResp> AcctDtlInfoQry([FromBody]AcctDtlInfoQryReq acctInfoReq)
        {
            BaseResponse<AcctDtlInfoQryResp> baseResponse = new BaseResponse<AcctDtlInfoQryResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(acctInfoReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.AcctDtlInfoQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<AcctDtlInfoQryResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 单笔划拨
        /// </summary>
        /// <param name="singleTransferReq">请求参数</param>
        [HttpPost]
        public BaseResponse<SingleTransferResp> SingleTransfer([FromBody]SingleTransferReq singleTransferReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<SingleTransferResp> baseResponse = new BaseResponse<SingleTransferResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(singleTransferReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.SingleTransfer, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<SingleTransferResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 单笔划拨结果查询
        /// </summary>
        /// <param name="snglTrsfRstlQryReq">请求参数</param>
        [HttpPost]
        public BaseResponse<SnglTrsfRstlQryResp> SnglTrsfRstlQry([FromBody]SnglTrsfRstlQryReq snglTrsfRstlQryReq)
        {
            BaseResponse<SnglTrsfRstlQryResp> baseResponse = new BaseResponse<SnglTrsfRstlQryResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(snglTrsfRstlQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.SnglTrsfRstlQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<SnglTrsfRstlQryResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 电子回单申请
        /// </summary>
        /// <param name="electRecptApplctionReq">请求参数</param>
        [HttpPost]
        public BaseResponse<ElectRecptApplctionResp> ElectRecptApplction([FromBody]ElectRecptApplctionReq electRecptApplctionReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<ElectRecptApplctionResp> baseResponse = new BaseResponse<ElectRecptApplctionResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(electRecptApplctionReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.ElectRecptApplction, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<ElectRecptApplctionResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 三方解约
        /// </summary>
        /// <param name="fncThdCnclReq">请求参数</param>
        [HttpPost]
        public BaseResponse<FncThdCnclResp> FncThdCncl([FromBody]FncThdCnclReq fncThdCnclReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<FncThdCnclResp> baseResponse = new BaseResponse<FncThdCnclResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(fncThdCnclReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.FncThdCncl, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<FncThdCnclResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 退汇附加信息查询
        /// </summary>
        /// <param name="rexgAddInfoQryReq">请求参数</param>
        [HttpPost]
        public BaseResponse<RexgAddInfoQryResp> RexgAddInfoQry([FromBody]RexgAddInfoQryReq rexgAddInfoQryReq)
        {
            BaseResponse<RexgAddInfoQryResp> baseResponse = new BaseResponse<RexgAddInfoQryResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(rexgAddInfoQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.RexgAddInfoQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<RexgAddInfoQryResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 根据抹账流水查原往账流水
        /// </summary>
        /// <param name="bnkInfoQryCombntnTranReq">请求参数</param>
        [HttpPost]
        public BaseResponse<BnkInfoQryCombntnTranResp> BnkInfoQryCombntnTran([FromBody]BnkInfoQryCombntnTranReq bnkInfoQryCombntnTranReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<BnkInfoQryCombntnTranResp> baseResponse = new BaseResponse<BnkInfoQryCombntnTranResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(bnkInfoQryCombntnTranReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.BnkInfoQryCombntnTran, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<BnkInfoQryCombntnTranResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 单笔资金划拨小额鉴权
        /// </summary>
        /// <param name="authSmlAmt">请求参数</param>
        [HttpPost]
        public BaseResponse<AuthSmlAmtResp> AuthSmlAmt([FromBody]AuthSmlAmtReq authSmlAmt)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<AuthSmlAmtResp> baseResponse = new BaseResponse<AuthSmlAmtResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(authSmlAmt, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.AuthSmlAmt, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<AuthSmlAmtResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 支付指令登记
        /// </summary>
        /// <param name="payInsrChkReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<PayInsrChkResp> PayInsrChk([FromBody]PayInsrChkReq payInsrChkReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<PayInsrChkResp> baseResponse = new BaseResponse<PayInsrChkResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(payInsrChkReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.PayInsrChk, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<PayInsrChkResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 支付指令明细查询
        /// </summary>
        /// <param name="payInsrDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<PayInsrDtlQryResp> PayInsrDtlQry([FromBody]PayInsrDtlQryReq payInsrDtlQryReq)
        {
            BaseResponse<PayInsrDtlQryResp> baseResponse = new BaseResponse<PayInsrDtlQryResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(payInsrDtlQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.PayInsrDtlQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<PayInsrDtlQryResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 支付指令取消
        /// </summary>
        /// <param name="payInsrCnlReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<PayInsrCnlResp> PayInsrCnl([FromBody]PayInsrCnlReq payInsrCnlReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<PayInsrCnlResp> baseResponse = new BaseResponse<PayInsrCnlResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(payInsrCnlReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.PayInsrCnl, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<PayInsrCnlResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 收款人白名单查询
        /// </summary>
        /// <param name="payeeWhtLstQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<PayeeWhtLstQryResp> PayeeWhtLstQry([FromBody]PayeeWhtLstQryReq payeeWhtLstQryReq)
        {
            BaseResponse<PayeeWhtLstQryResp> baseResponse = new BaseResponse<PayeeWhtLstQryResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(payeeWhtLstQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.PayeeWhtLstQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<PayeeWhtLstQryResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 收款人白名单维护----------------------------------------e账通标准API接口结束----------------------------------------
        /// </summary>
        /// <param name="payeeWhtLstMntnReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<PayeeWhtLstMntnResp> PayeeWhtLstMntn([FromBody]PayeeWhtLstMntnReq payeeWhtLstMntnReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<PayeeWhtLstMntnResp> baseResponse = new BaseResponse<PayeeWhtLstMntnResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(payeeWhtLstMntnReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.PayeeWhtLstMntn, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<PayeeWhtLstMntnResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        #endregion

        #region e商贷API接口

        /// <summary>
        /// 备付金或结算户转客户结算户----------------------------------------e商贷API接口开始----------------------------------------
        /// </summary>
        /// <param name="zLSysInrBnkTfrReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<ZLSysInrBnkTfrResp> ZLSysInrBnkTfr([FromBody]ZLSysInrBnkTfrReq zLSysInrBnkTfrReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<ZLSysInrBnkTfrResp> baseResponse = new BaseResponse<ZLSysInrBnkTfrResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(zLSysInrBnkTfrReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.ZLSysInrBnkTfr, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<ZLSysInrBnkTfrResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 贷款归还
        /// </summary>
        /// <param name="olBrwLnRepyReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<OlBrwLnRepyResp> OlBrwLnRepy([FromBody]OlBrwLnRepyReq olBrwLnRepyReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<OlBrwLnRepyResp> baseResponse = new BaseResponse<OlBrwLnRepyResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(olBrwLnRepyReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.OlBrwLnRepy, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<OlBrwLnRepyResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 贷款还款明细查询
        /// </summary>
        /// <param name="intDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<IntDtlQryResp> IntDtlQry([FromBody]IntDtlQryReq intDtlQryReq)
        {
            BaseResponse<IntDtlQryResp> baseResponse = new BaseResponse<IntDtlQryResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(intDtlQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.IntDtlQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<IntDtlQryResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 贷款试算
        /// </summary>
        /// <param name="interestTrialReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<InterestTrialResp> InterestTrial([FromBody]InterestTrialReq interestTrialReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<InterestTrialResp> baseResponse = new BaseResponse<InterestTrialResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(interestTrialReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.InterestTrial, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<InterestTrialResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 电子回单申请
        /// </summary>
        /// <param name="receiptApplyReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<ReceiptApplyResp> ReceiptApply([FromBody]ReceiptApplyReq receiptApplyReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<ReceiptApplyResp> baseResponse = new BaseResponse<ReceiptApplyResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(receiptApplyReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.ReceiptApply, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<ReceiptApplyResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 对公贷款还款维护
        /// </summary>
        /// <param name="corpLnCntlAcctReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<CorpLnCntlAcctResp> CorpLnCntlAcctRep([FromBody]CorpLnCntlAcctReq corpLnCntlAcctReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<CorpLnCntlAcctResp> baseResponse = new BaseResponse<CorpLnCntlAcctResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(corpLnCntlAcctReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.CorpLnCntlAcctRep, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<CorpLnCntlAcctResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 归还贷款本金利息试算
        /// </summary>
        /// <param name="olBrwLnRepyTrlReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<OlBrwLnRepyTrlResp> OlBrwLnRepyTrl([FromBody]OlBrwLnRepyTrlReq olBrwLnRepyTrlReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<OlBrwLnRepyTrlResp> baseResponse = new BaseResponse<OlBrwLnRepyTrlResp>
            {
                DateTime = Now
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(olBrwLnRepyTrlReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.OlBrwLnRepyTrl, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<OlBrwLnRepyTrlResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();

            });
            return baseResponse;
        }

        /// <summary>
        /// 还款查询
        /// </summary>
        /// <param name="coreTranQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<CoreTranQryResp> CoreTranQry([FromBody]CoreTranQryReq coreTranQryReq)
        {
            BaseResponse<CoreTranQryResp> baseResponse = new BaseResponse<CoreTranQryResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(coreTranQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.CoreTranQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<CoreTranQryResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 划拨结果查询
        /// </summary>
        /// <param name="zLSysBussBkQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<ZLSysBussBkQryResp> ZLSysBussBkQry([FromBody]ZLSysBussBkQryReq zLSysBussBkQryReq)
        {
            BaseResponse<ZLSysBussBkQryResp> baseResponse = new BaseResponse<ZLSysBussBkQryResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(zLSysBussBkQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.ZLSysBussBkQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<ZLSysBussBkQryResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 借据详细信息查看
        /// </summary>
        /// <param name="lnRcrdDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<LnRcrdDtlQryResp> LnRcrdDtlQry([FromBody]LnRcrdDtlQryReq lnRcrdDtlQryReq)
        {
            BaseResponse<LnRcrdDtlQryResp> baseResponse = new BaseResponse<LnRcrdDtlQryResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(lnRcrdDtlQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.LnRcrdDtlQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<LnRcrdDtlQryResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 借据应还本金利息查询
        /// </summary>
        /// <param name="corpAgngLnRcvblntQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<CorpAgngLnRcvblntQryResp> CorpAgngLnRcvblntQry([FromBody]CorpAgngLnRcvblntQryReq corpAgngLnRcvblntQryReq)
        {
            BaseResponse<CorpAgngLnRcvblntQryResp> baseResponse = new BaseResponse<CorpAgngLnRcvblntQryResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(corpAgngLnRcvblntQryReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.CorpAgngLnRcvblntQry, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<CorpAgngLnRcvblntQryResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        /// <summary>
        /// 已放贷款还款计划查询----------------------------------------e商贷API接口结束----------------------------------------
        /// </summary>
        /// <param name="crpLnIntTrlReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public BaseResponse<CrpLnIntTrlResp> CrpLnIntTrl([FromBody]CrpLnIntTrlReq crpLnIntTrlReq)
        {
            BaseResponse<CrpLnIntTrlResp> baseResponse = new BaseResponse<CrpLnIntTrlResp>
            {
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            int code = 0; //http请求错误码
            ResponseType responseType;
            var header = GetHeaderSign(crpLnIntTrlReq, out string dataRequest);
            HttpClientHelper.POSTRequest(SPDBankConfig.CrpLnIntTrl, dataRequest, header, (statusCode, result) =>
            {
                code = (int)statusCode;
                baseResponse.Code = code;
                baseResponse.Data = result.ToObject<CrpLnIntTrlResp>();

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return baseResponse;
        }

        #endregion

    }
}




