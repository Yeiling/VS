using Microsoft.AspNetCore.Mvc;
using shuiyintong.Common;
using shuiyintong.Common.Extend;
using shuiyintong.DBUtils;
using shuiyintong.DBUtils.IService;
using shuiyintong.DBUtils.SYT_apiDB_TestEntity;
using shuiyintong.Entity;
using shuiyintong.Entity.SPDBankEntity.SPDBankReq;
using shuiyintong.Entity.SPDBankEntity.SPDResp;
using shuiyintong.SPDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static shuiyintong.Entity.Enums.BankTypeEum;
using static shuiyintong.Entity.Enums.RedisDBEnum;
using static shuiyintong.Entity.Enums.RespCodeEnum;
using static shuiyintong.Entity.SPDBankEntity.SPDBankAPITypeEunm;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// 浦发银行接口
    /// </summary>
    public class SPDBankController : BaseController
    {
        /// <summary>
        /// 账户信息注入
        /// </summary>
        //public IBaseService<AcctDtlInfoQry> AcctDtlInfoServer { get; set; }


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


        #region 接口
        /// <summary>
        /// 获取账户信息
        /// </summary>
        /// <param name="accountRequest">请求参数</param>
        [HttpPost]
        public string AcctInfo([FromBody]AccountReq accountRequest)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.AcctInfo).ToString() + "-" + Now + "-"; ; //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                APICode = (int)SPDBankAPIType.AcctInfo,
                APIName = SPDBankAPIType.AcctInfo.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(accountRequest, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.AcctInfo, dataRequest, header, (statusCode, result) =>
                 {
                     code = (int)statusCode;
                     responseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                     BaseResponse<string> baseResponse = new BaseResponse<string>
                     {
                         Code = code,
                         Data = result,
                         ResponseType = responseType,
                         DateTime = Now
                     };

                     //Redis保存
                     key += responseType;
                     redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                     if (redis != null)
                         redis.Set(key, baseResponse);
                 });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                //保存日志
                key += responseType;
                redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                if (redis != null)
                    redis.Set(key, log);
            }
            return resultStr;
        }

        /// <summary>
        /// 查询账户信息
        /// </summary>
        /// <param name="acctInfoReq">请求参数</param>
        [HttpPost]
        public string AcctDtlInfoQry([FromBody]AcctDtlInfoQryReq acctInfoReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.AcctDtlInfoQry).ToString() + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                APICode = (int)SPDBankAPIType.AcctDtlInfoQry,
                APIName = SPDBankAPIType.AcctDtlInfoQry.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(acctInfoReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.AcctDtlInfoQry, dataRequest, header, (statusCode, result) =>
                  {
                      code = (int)statusCode;
                      responseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                      BaseResponse<string> baseResponse = new BaseResponse<string>
                      {
                          Code = code,
                          Data = result,
                          ResponseType = responseType,
                          DateTime = Now
                      };

                      //Redis保存
                      key += responseType;
                      redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                      if (redis != null)
                          redis.Set(key, baseResponse);
                  });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
                //保存日志
                redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                if (redis != null)
                    redis.Set(key, log);
            }
            return resultStr;
        }

        /// <summary>
        /// 单笔划拨
        /// </summary>
        /// <param name="singleTransferReq">请求参数</param>
        [HttpPost]
        public string SingleTransfer([FromBody]SingleTransferReq singleTransferReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.SingleTransfer).ToString() + "-" + Now + "-"; ; //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                APICode = (int)SPDBankAPIType.SingleTransfer,
                APIName = SPDBankAPIType.SingleTransfer.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(singleTransferReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.SingleTransfer, dataRequest, header, (statusCode, result) =>
                  {
                      code = (int)statusCode;
                      responseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                      responseType = (byte)ResponseType.Success;
                      BaseResponse<string> baseResponse = new BaseResponse<string>
                      {
                          Code = code,
                          Data = result,
                          ResponseType = responseType,
                          DateTime = Now
                      };

                      //Redis保存
                      key += responseType;
                      redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                      if (redis != null)
                          redis.Set(key, baseResponse);
                  });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
                //保存日志
                redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                if (redis != null)
                    redis.Set(key, log);
            }
            return resultStr;
        }

        /// <summary>
        /// 单笔划拨结果查询
        /// </summary>
        /// <param name="snglTrsfRstlQryReq">请求参数</param>
        [HttpPost]
        public string SnglTrsfRstlQryReq([FromBody]SnglTrsfRstlQryReq snglTrsfRstlQryReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.SnglTrsfRstlQry).ToString() + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                APICode = (int)SPDBankAPIType.SnglTrsfRstlQry,
                APIName = SPDBankAPIType.SnglTrsfRstlQry.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(snglTrsfRstlQryReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.SnglTrsfRstlQry, dataRequest, header, (statusCode, result) =>
                 {
                     code = (int)statusCode;
                     responseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                     BaseResponse<string> baseResponse = new BaseResponse<string>
                     {
                         Code = code,
                         Data = result,
                         ResponseType = responseType,
                         DateTime = Now
                     };

                     //Redis保存
                     key += responseType;
                     redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                     if (redis != null)
                         redis.Set(key, baseResponse);
                 });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
                //保存日志
                redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                if (redis != null)
                    redis.Set(key, log);
            }
            return resultStr;
        }

        /// <summary>
        /// 电子回单申请
        /// </summary>
        /// <param name="electRecptApplctionReq">请求参数</param>
        [HttpPost]
        public string ElectRecptApplction([FromBody]ElectRecptApplctionReq electRecptApplctionReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.ElectRecptApplction).ToString() + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                APICode = (int)SPDBankAPIType.ElectRecptApplction,
                APIName = SPDBankAPIType.ElectRecptApplction.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(electRecptApplctionReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.ElectRecptApplction, dataRequest, header, (statusCode, result) =>
                  {
                      code = (int)statusCode;
                      responseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                      BaseResponse<string> baseResponse = new BaseResponse<string>
                      {
                          Code = code,
                          Data = result,
                          ResponseType = responseType,
                          DateTime = Now
                      };

                      //Redis保存
                      key += responseType;
                      redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                      if (redis != null)
                          redis.Set(key, baseResponse);
                  });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
                //保存日志
                redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                if (redis != null)
                    redis.Set(key, log);
            }
            return resultStr;
        }

        /// <summary>
        /// 三方解约
        /// </summary>
        /// <param name="fncThdCnclReq">请求参数</param>
        [HttpPost]
        public string FncThdCncl([FromBody]FncThdCnclReq fncThdCnclReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.FncThdCncl).ToString() + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                APICode = (int)SPDBankAPIType.FncThdCncl,
                APIName = SPDBankAPIType.FncThdCncl.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(fncThdCnclReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.FncThdCncl, dataRequest, header, (statusCode, result) =>
                 {
                     code = (int)statusCode;
                     responseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                     BaseResponse<string> baseResponse = new BaseResponse<string>
                     {
                         Code = code,
                         Data = result,
                         ResponseType = responseType,
                         DateTime = Now
                     };

                     //Redis保存
                     key += responseType;
                     redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                     if (redis != null)
                         redis.Set(key, baseResponse);
                 });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
                //保存日志
                redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                if (redis != null)
                    redis.Set(key, log);
            }
            return resultStr;
        }

        /// <summary>
        /// 退汇附加信息查询
        /// </summary>
        /// <param name="rexgAddInfoQryReq">请求参数</param>
        [HttpPost]
        public string RexgAddInfoQry([FromBody]RexgAddInfoQryReq rexgAddInfoQryReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.RexgAddInfoQry).ToString() + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                APICode = (int)SPDBankAPIType.RexgAddInfoQry,
                APIName = SPDBankAPIType.RexgAddInfoQry.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(rexgAddInfoQryReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.RexgAddInfoQry, dataRequest, header, (statusCode, result) =>
                  {
                      code = (int)statusCode;
                      responseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                      BaseResponse<string> baseResponse = new BaseResponse<string>
                      {
                          Code = code,
                          Data = result,
                          ResponseType = responseType,
                          DateTime = Now
                      };

                      //Redis保存
                      key += responseType;
                      redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                      if (redis != null)
                          redis.Set(key, baseResponse);
                  });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
                //保存日志
                redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                if (redis != null)
                    redis.Set(key, log);
            }
            return resultStr;
        }

        /// <summary>
        /// 根据抹账流水查原往账流水
        /// </summary>
        /// <param name="bnkInfoQryCombntnTranReq">请求参数</param>
        [HttpPost]
        public string BnkInfoQryCombntnTran([FromBody]BnkInfoQryCombntnTranReq bnkInfoQryCombntnTranReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.BnkInfoQryCombntnTran).ToString() + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                APICode = (int)SPDBankAPIType.BnkInfoQryCombntnTran,
                APIName = SPDBankAPIType.BnkInfoQryCombntnTran.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(bnkInfoQryCombntnTranReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.BnkInfoQryCombntnTran, dataRequest, header, (statusCode, result) =>
                  {
                      code = (int)statusCode;
                      responseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                      BaseResponse<string> baseResponse = new BaseResponse<string>
                      {
                          Code = code,
                          Data = result,
                          ResponseType = responseType,
                          DateTime = Now
                      };

                      //Redis保存
                      key += responseType;
                      redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                      if (redis != null)
                          redis.Set(key, baseResponse);
                  });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
                //保存日志
                redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                if (redis != null)
                    redis.Set(key, log);
            }
            return resultStr;
        }

        /// <summary>
        /// 单笔资金划拨小额鉴权
        /// </summary>
        /// <param name="authSmlAmt">请求参数</param>
        [HttpPost]
        public string AuthSmlAmt([FromBody]AuthSmlAmtReq authSmlAmt)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.AuthSmlAmt).ToString() + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                APICode = (int)SPDBankAPIType.AuthSmlAmt,
                APIName = SPDBankAPIType.AuthSmlAmt.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(authSmlAmt, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.AuthSmlAmt, dataRequest, header, (statusCode, result) =>
                 {
                     code = (int)statusCode;
                     responseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                     BaseResponse<string> baseResponse = new BaseResponse<string>
                     {
                         Code = code,
                         Data = result,
                         ResponseType = responseType,
                         DateTime = Now
                     };

                     //Redis保存
                     key += responseType;
                     redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                     if (redis != null)
                         redis.Set(key, baseResponse);
                 });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
                //保存日志
                redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                if (redis != null)
                    redis.Set(key, log);
            }
            return resultStr;
        }

        /// <summary>
        /// 支付指令登记
        /// </summary>
        /// <param name="payInsrChkReq"></param>
        /// <returns></returns>
        [HttpPost]
        public string PayInsrChk([FromBody]PayInsrChkReq payInsrChkReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.PayInsrChk).ToString() + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                APICode = (int)SPDBankAPIType.PayInsrChk,
                APIName = SPDBankAPIType.PayInsrChk.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(payInsrChkReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.PayInsrChk, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };

                    //Redis保存
                    key += responseType;
                    redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                    if (redis != null)
                        redis.Set(key, baseResponse);
                });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
                //保存日志
                redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                if (redis != null)
                    redis.Set(key, log);
            }
            return resultStr;
        }


        #endregion





    }
}
