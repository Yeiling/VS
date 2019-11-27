using Microsoft.AspNetCore.Mvc;
using shuiyintong.Common;
using shuiyintong.Common.Extend;
using shuiyintong.Common.NPOIFile;
using shuiyintong.DBUtils;
using shuiyintong.DBUtils.IService;
using shuiyintong.DBUtils.Test_tuishui_Demo;
using shuiyintong.Entity.AppSettiongModel;
using shuiyintong.Entity.HttpRequestResultEntity;
using shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq;
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
using static shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq.DeductionEnum;
using WTPC_ERR = shuiyintong.Entity.SPDBankEntity.SPDBankFile.WTPC_ERR;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 浦发银行接口
    /// </summary>
    public class SPDBankController : BaseController
    {
        #region 数据库操作相关服务
        /// <summary>
        /// 项目审批信息
        /// </summary>
        public IBaseService<tb_ProjectApproval> ProjectApprovalServer { get; set; }
        /// <summary>
        /// 订单表服务
        /// </summary>
        public IBaseService<tb_productOrder> ProductOrderServer { get; set; }

        /// <summary>
        /// 退税账户核验
        /// </summary>
        public IBaseService<tb_TaxVerification> TaxVerificationServer { get; set; }
        /// <summary>
        /// 公司账户
        /// </summary>
        public IBaseService<tb_companyAccount> CompanyAccountServer { get; set; }


        #endregion

        #region 银行配置缓存

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
        /// 担保函导出Word文档----------------------------------------生成担保函--------------------
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
        /// 文件上传---扩展测试----------------------------------------文件上传下载开始--------------------
        /// </summary>
        /// <param name="file">文件参数</param>
        /// <returns></returns>
        [HttpPost]
        public string UpLoadfileExt(SPDBankFileUpLoadReqExt file)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "UpLoadFile\\";

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
        /// 文件下载------------------------------------------------------------文件上传下载结束--------------------
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
        /// 获取账户信息----------------------------------------e账通标准API接口开始--------------------
        /// </summary>
        /// <param name="accountRequest">请求参数</param>
        [HttpPost]
        public JsonResult AcctInfo([FromBody]AccountReq accountRequest)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 查询账户信息
        /// </summary>
        /// <param name="acctInfoReq">请求参数</param>
        [HttpPost]
        public JsonResult AcctDtlInfoQry([FromBody]AcctDtlInfoQryReq acctInfoReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 单笔划拨
        /// </summary>
        /// <param name="singleTransferReq">请求参数</param>
        [HttpPost]
        public JsonResult SingleTransfer([FromBody]SingleTransferReq singleTransferReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.SingleTransfer + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 单笔划拨结果查询
        /// </summary>
        /// <param name="snglTrsfRstlQryReq">请求参数</param>
        [HttpPost]
        public JsonResult SnglTrsfRstlQry([FromBody]SnglTrsfRstlQryReq snglTrsfRstlQryReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 电子回单申请
        /// </summary>
        /// <param name="electRecptApplctionReq">请求参数</param>
        [HttpPost]
        public JsonResult ElectRecptApplction([FromBody]ElectRecptApplctionReq electRecptApplctionReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.ElectRecptApplction + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 三方解约
        /// </summary>
        /// <param name="fncThdCnclReq">请求参数</param>
        [HttpPost]
        public JsonResult FncThdCncl([FromBody]FncThdCnclReq fncThdCnclReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.FncThdCncl + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 退汇附加信息查询
        /// </summary>
        /// <param name="rexgAddInfoQryReq">请求参数</param>
        [HttpPost]
        public JsonResult RexgAddInfoQry([FromBody]RexgAddInfoQryReq rexgAddInfoQryReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 根据抹账流水查原往账流水
        /// </summary>
        /// <param name="bnkInfoQryCombntnTranReq">请求参数</param>
        [HttpPost]
        public JsonResult BnkInfoQryCombntnTran([FromBody]BnkInfoQryCombntnTranReq bnkInfoQryCombntnTranReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.BnkInfoQryCombntnTran + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 单笔资金划拨小额鉴权
        /// </summary>
        /// <param name="authSmlAmt">请求参数</param>
        [HttpPost]
        public JsonResult AuthSmlAmt([FromBody]AuthSmlAmtReq authSmlAmt)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.AuthSmlAmt + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 支付指令登记
        /// </summary>
        /// <param name="payInsrChkReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PayInsrChk([FromBody]PayInsrChkReq payInsrChkReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.PayInsrChk + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 支付指令明细查询
        /// </summary>
        /// <param name="payInsrDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PayInsrDtlQry([FromBody]PayInsrDtlQryReq payInsrDtlQryReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 支付指令取消
        /// </summary>
        /// <param name="payInsrCnlReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PayInsrCnl([FromBody]PayInsrCnlReq payInsrCnlReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.PayInsrCnl + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 收款人白名单查询
        /// </summary>
        /// <param name="payeeWhtLstQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PayeeWhtLstQry([FromBody]PayeeWhtLstQryReq payeeWhtLstQryReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 收款人白名单维护----------------------------------------e账通标准API接口结束--------------------
        /// </summary>
        /// <param name="payeeWhtLstMntnReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult PayeeWhtLstMntn([FromBody]PayeeWhtLstMntnReq payeeWhtLstMntnReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.PayeeWhtLstMntn + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        #endregion

        #region e商贷API接口

        /// <summary>
        /// 备付金或结算户转客户结算户----------------------------------------e商贷API接口开始--------------------
        /// </summary>
        /// <param name="zLSysInrBnkTfrReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ZLSysInrBnkTfr([FromBody]ZLSysInrBnkTfrReq zLSysInrBnkTfrReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.ZLSysInrBnkTfr + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 贷款归还
        /// </summary>
        /// <param name="olBrwLnRepyReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult OlBrwLnRepy([FromBody]OlBrwLnRepyReq olBrwLnRepyReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.OlBrwLnRepy + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 贷款还款明细查询
        /// </summary>
        /// <param name="intDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult IntDtlQry([FromBody]IntDtlQryReq intDtlQryReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 贷款试算
        /// </summary>
        /// <param name="interestTrialReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult InterestTrial([FromBody]InterestTrialReq interestTrialReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.InterestTrial + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 电子回单申请
        /// </summary>
        /// <param name="receiptApplyReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ReceiptApply([FromBody]ReceiptApplyReq receiptApplyReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.ReceiptApply + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 对公贷款还款维护
        /// </summary>
        /// <param name="corpLnCntlAcctReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CorpLnCntlAcctRep([FromBody]CorpLnCntlAcctReq corpLnCntlAcctReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.CorpLnCntlAcctRep + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 归还贷款本金利息试算
        /// </summary>
        /// <param name="olBrwLnRepyTrlReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult OlBrwLnRepyTrl([FromBody]OlBrwLnRepyTrlReq olBrwLnRepyTrlReq)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
                //Redis保存 //Redis key
                string key = (int)SPDBank + "-" + (int)SPDBankAPIType.OlBrwLnRepyTrl + "-" + Now + "-" + baseResponse.ResponseType;
                if (redis != null)
                    redis.Set(key, baseResponse);

            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 还款查询
        /// </summary>
        /// <param name="coreTranQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CoreTranQry([FromBody]CoreTranQryReq coreTranQryReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 划拨结果查询
        /// </summary>
        /// <param name="zLSysBussBkQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ZLSysBussBkQry([FromBody]ZLSysBussBkQryReq zLSysBussBkQryReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 借据详细信息查看
        /// </summary>
        /// <param name="lnRcrdDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult LnRcrdDtlQry([FromBody]LnRcrdDtlQryReq lnRcrdDtlQryReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 借据应还本金利息查询
        /// </summary>
        /// <param name="corpAgngLnRcvblntQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CorpAgngLnRcvblntQry([FromBody]CorpAgngLnRcvblntQryReq corpAgngLnRcvblntQryReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        /// <summary>
        /// 已放贷款还款计划查询----------------------------------------e商贷API接口结束--------------------
        /// </summary>
        /// <param name="crpLnIntTrlReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CrpLnIntTrl([FromBody]CrpLnIntTrlReq crpLnIntTrlReq)
        {
            BaseResponse<string> baseResponse = new BaseResponse<string>
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
                baseResponse.Data = result;

                responseType = code == Code ? ResponseType.Success : ResponseType.Fail;
                baseResponse.ResponseType = (byte)responseType;
                baseResponse.Msg = responseType.GetDescription();
            });
            return Json(baseResponse);
        }

        #endregion

        #region 平台接口---税单贷自动付款

        #region 授信
        /// <summary>
        /// 授信(数据表tb_ProjectApproval)---项目审批信息(银行)，项目风险信息(尽调+征信)----------------------------------------(银行回传平台)接口开始--------------------
        /// </summary>
        /// <param name="projectApproval">类型</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CreditBKApprove([FromBody]ProjectApproval projectApproval)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (projectApproval == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            //审批意见为“拒绝”，则需“备注”说明。approvalOpinion=true表示通过，approvalOpinion=false表示拒绝
            if (!projectApproval.approvalOpinion && string.IsNullOrWhiteSpace(projectApproval.remarks))
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "审批意见为“拒绝”，则必须填写“备注”说明",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            tb_ProjectApproval ProjectApprovalModel = new tb_ProjectApproval
            {
                platformAcctNo = projectApproval.platformAcctNo,
                enterpriseName = projectApproval.enterpriseName,
                approvalOpinion = projectApproval.approvalOpinion,
                remarks = projectApproval.remarks,
                enterpriseScale = projectApproval.enterpriseScale,
                planningEnterprise = projectApproval.planningEnterprise,
                businessIncome = projectApproval.businessIncome,
                practitioners = projectApproval.practitioners,
                totalAssets = projectApproval.totalAssets,
                IsFitReq = projectApproval.IsFitReq,
                proportion = projectApproval.proportion,
                overdueFrequency = projectApproval.overdueFrequency,
                overdueTotalFrequency = projectApproval.overdueTotalFrequency,
                createTime = DateTime.Now
            };
            bool bol = ProjectApprovalServer.AddOne(ProjectApprovalModel); //保存推送数据
            if (bol)
            {
                string Status = string.Empty;  //数据库订单表状态
                switch (projectApproval.approvalOpinion)
                {
                    case true:
                        Status = "0100";  //通过审批
                        break;
                    default:
                        Status = "11";  //审批拒绝
                        break;
                }

                //更新tb_productOrder表订单状态
                ProductOrderServer.Modefy(p => p.OrderNo == projectApproval.platformAcctNo,
                    po => new tb_productOrder { status = Status, updatetime = DateTime.Now });

                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Success,
                    Data = ProjectApprovalModel.ToJson(),
                    DateTime = Now,
                    Msg = InteractiveCode.Success.GetDescription()
                });
            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }

        /// <summary>
        /// 授信(数据表tb_TaxVerification) 退税账户核验信息
        /// </summary>
        /// <param name="taxVerification"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CreditBKVer([FromBody]TaxVerification taxVerification)
        {
            string Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (taxVerification == null)
            {
                return Json(new BaseResponse<string>
                {
                    Code = 500,
                    ResponseType = (byte)InteractiveCode.Fail,
                    Data = "请求参数无效，没有推送成功",
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
            tb_TaxVerification TaxVerificationModel = new tb_TaxVerification
            {
                platformAcctNo = taxVerification.platformAcctNo,
                enterpriseName = taxVerification.enterpriseName,
                accountName = taxVerification.accountName,
                acctNo = taxVerification.acctNo,
                openBank = taxVerification.openBank,
                IsDrawback = taxVerification.IsDrawback,
                createTime = DateTime.Now
            };
            bool bol = TaxVerificationServer.AddOne(TaxVerificationModel); //保存推送数据
            if (bol)
            {
                string BankConfirmFlag = string.Empty, Status = string.Empty;  //数据库订单表状态;    
                switch (TaxVerificationModel.IsDrawback)
                {
                    case true:
                        Status = "0100_pass";  //通过审批
                        BankConfirmFlag = "1";  //退税账户
                        break;
                    default:
                        Status = "0100_fail";  //审批拒绝
                        BankConfirmFlag = "0";  //非退税账户
                        break;
                }

                //更新tb_productOrder表订单状态
                ProductOrderServer.Modefy(p => p.OrderNo == taxVerification.platformAcctNo,
                    po => new tb_productOrder { status = Status, updatetime = DateTime.Now });
                //更新tb_companyAccount表标识
                CompanyAccountServer.Modefy(p => p.OrderNo == taxVerification.platformAcctNo,
                    po => new tb_companyAccount { bankConfirmFlag = BankConfirmFlag });

                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Success,
                    Data = TaxVerificationModel.ToJson(),
                    DateTime = Now,
                    Msg = InteractiveCode.Success.GetDescription()
                });
            }
            else  //推送失败提示信息
            {
                return Json(new BaseResponse<string>
                {
                    Code = 200,
                    ResponseType = (byte)InteractiveCode.Fail,
                    DateTime = Now,
                    Msg = InteractiveCode.Fail.GetDescription()
                });
            }
        }
        #endregion

        #endregion

    }
}




