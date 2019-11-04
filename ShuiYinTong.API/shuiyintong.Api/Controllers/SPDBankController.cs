using Autofac.Extras.DynamicProxy;
using log4net;
using Microsoft.AspNetCore.Mvc;
using shuiyintong.Api.AutoFacAop;
using shuiyintong.Common;
using shuiyintong.Common.BankConfig;
using shuiyintong.Common.Extend;
using shuiyintong.DBUtils;
using shuiyintong.DBUtils.IService;
using shuiyintong.DBUtils.SYT_apiDB_TestEntity;
using shuiyintong.Entity;
using shuiyintong.Entity.SPDBankEntity.SPDBankReq;
using shuiyintong.SPDB;
using System;
using System.Collections.Generic;
using static shuiyintong.Entity.Enums.BankTypeEum;
using static shuiyintong.Entity.Enums.RedisDBEnum;
using static shuiyintong.Entity.Enums.RespCodeEnum;
using static shuiyintong.Entity.SPDBankEntity.SPDBankAPITypeEunm;

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


        #region e账通标准API接口

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
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.AcctInfo;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(accountRequest, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.AcctInfo, dataRequest, header, (statusCode, result) =>
                 {
                     code = (int)statusCode;
                     responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                     BaseResponse<string> baseResponse = new BaseResponse<string>
                     {
                         Code = code,
                         Data = result,
                         ResponseType = responseType,
                         DateTime = Now
                     };

                     //Redis保存
                     key += responseType;
                     redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                     if (redis != null)
                         redis.Set(key, baseResponse);
                 });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

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
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.AcctDtlInfoQry;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(acctInfoReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.AcctDtlInfoQry, dataRequest, header, (statusCode, result) =>
                  {
                      code = (int)statusCode;
                      responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                      BaseResponse<string> baseResponse = new BaseResponse<string>
                      {
                          Code = code,
                          Data = result,
                          ResponseType = responseType,
                          DateTime = Now
                      };

                      //Redis保存
                      key += responseType;
                      redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                      if (redis != null)
                          redis.Set(key, baseResponse);
                  });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

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
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.SingleTransfer;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(singleTransferReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.SingleTransfer, dataRequest, header, (statusCode, result) =>
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

                      //Redis保存
                      key += responseType;
                      redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                      if (redis != null)
                          redis.Set(key, baseResponse);
                  });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

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
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.SnglTrsfRstlQry;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(snglTrsfRstlQryReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.SnglTrsfRstlQry, dataRequest, header, (statusCode, result) =>
                 {
                     code = (int)statusCode;
                     responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                     BaseResponse<string> baseResponse = new BaseResponse<string>
                     {
                         Code = code,
                         Data = result,
                         ResponseType = responseType,
                         DateTime = Now
                     };

                     //Redis保存
                     key += responseType;
                     redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                     if (redis != null)
                         redis.Set(key, baseResponse);
                 });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

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
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.ElectRecptApplction;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(electRecptApplctionReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.ElectRecptApplction, dataRequest, header, (statusCode, result) =>
                  {
                      code = (int)statusCode;
                      responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                      BaseResponse<string> baseResponse = new BaseResponse<string>
                      {
                          Code = code,
                          Data = result,
                          ResponseType = responseType,
                          DateTime = Now
                      };

                      //Redis保存
                      key += responseType;
                      redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                      if (redis != null)
                          redis.Set(key, baseResponse);
                  });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

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
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.FncThdCncl;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(fncThdCnclReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.FncThdCncl, dataRequest, header, (statusCode, result) =>
                 {
                     code = (int)statusCode;
                     responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                     BaseResponse<string> baseResponse = new BaseResponse<string>
                     {
                         Code = code,
                         Data = result,
                         ResponseType = responseType,
                         DateTime = Now
                     };

                     //Redis保存
                     key += responseType;
                     redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                     if (redis != null)
                         redis.Set(key, baseResponse);
                 });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

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
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.RexgAddInfoQry;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(rexgAddInfoQryReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.RexgAddInfoQry, dataRequest, header, (statusCode, result) =>
                  {
                      code = (int)statusCode;
                      responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                      BaseResponse<string> baseResponse = new BaseResponse<string>
                      {
                          Code = code,
                          Data = result,
                          ResponseType = responseType,
                          DateTime = Now
                      };

                      //Redis保存
                      key += responseType;
                      redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                      if (redis != null)
                          redis.Set(key, baseResponse);
                  });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

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
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.BnkInfoQryCombntnTran;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(bnkInfoQryCombntnTranReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.BnkInfoQryCombntnTran, dataRequest, header, (statusCode, result) =>
                  {
                      code = (int)statusCode;
                      responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                      BaseResponse<string> baseResponse = new BaseResponse<string>
                      {
                          Code = code,
                          Data = result,
                          ResponseType = responseType,
                          DateTime = Now
                      };

                      //Redis保存
                      key += responseType;
                      redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                      if (redis != null)
                          redis.Set(key, baseResponse);
                  });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

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
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.AuthSmlAmt;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(authSmlAmt, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.AuthSmlAmt, dataRequest, header, (statusCode, result) =>
                 {
                     code = (int)statusCode;
                     responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                     BaseResponse<string> baseResponse = new BaseResponse<string>
                     {
                         Code = code,
                         Data = result,
                         ResponseType = responseType,
                         DateTime = Now
                     };

                     //Redis保存
                     key += responseType;
                     redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                     if (redis != null)
                         redis.Set(key, baseResponse);
                 });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

            return resultStr;
        }

        /// <summary>
        /// 支付指令登记
        /// </summary>
        /// <param name="payInsrChkReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string PayInsrChk([FromBody]PayInsrChkReq payInsrChkReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.PayInsrChk;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(payInsrChkReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.PayInsrChk, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };

                    //Redis保存
                    key += responseType;
                    redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                    if (redis != null)
                        redis.Set(key, baseResponse);
                });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

            return resultStr;
        }

        /// <summary>
        /// 支付指令明细查询
        /// </summary>
        /// <param name="payInsrDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string PayInsrDtlQry([FromBody]PayInsrDtlQryReq payInsrDtlQryReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.PayInsrDtlQry;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(payInsrDtlQryReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.PayInsrDtlQry, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };

                    //Redis保存
                    key += responseType;
                    redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                    if (redis != null)
                        redis.Set(key, baseResponse);
                });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

            return resultStr;
        }

        /// <summary>
        /// 支付指令取消
        /// </summary>
        /// <param name="payInsrCnlReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string PayInsrCnl([FromBody]PayInsrCnlReq payInsrCnlReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.PayInsrCnl;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(payInsrCnlReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.PayInsrCnl, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };

                    //Redis保存
                    key += responseType;
                    redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                    if (redis != null)
                        redis.Set(key, baseResponse);
                });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

            return resultStr;
        }

        /// <summary>
        /// 收款人白名单查询
        /// </summary>
        /// <param name="payeeWhtLstQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string PayeeWhtLstQry([FromBody]PayeeWhtLstQryReq payeeWhtLstQryReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.PayeeWhtLstQry;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(payeeWhtLstQryReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.PayeeWhtLstQry, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };

                    //Redis保存
                    key += responseType;
                    redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                    if (redis != null)
                        redis.Set(key, baseResponse);
                });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

            return resultStr;
        }

        /// <summary>
        /// 收款人白名单维护
        /// </summary>
        /// <param name="payeeWhtLstMntnReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string PayeeWhtLstMntn([FromBody]PayeeWhtLstMntnReq payeeWhtLstMntnReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.PayeeWhtLstMntn;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(payeeWhtLstMntnReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.PayeeWhtLstMntn, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };

                    //Redis保存
                    key += responseType;
                    redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                    if (redis != null)
                        redis.Set(key, baseResponse);
                });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

            return resultStr;
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
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.ZLSysInrBnkTfr;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(zLSysInrBnkTfrReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.ZLSysInrBnkTfr, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };

                    //Redis保存
                    key += responseType;
                    redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                    if (redis != null)
                        redis.Set(key, baseResponse);
                });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

            return resultStr;
        }

        /// <summary>
        /// 贷款归还
        /// </summary>
        /// <param name="olBrwLnRepyReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string OlBrwLnRepy([FromBody]OlBrwLnRepyReq olBrwLnRepyReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.OlBrwLnRepy;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(olBrwLnRepyReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.OlBrwLnRepy, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };

                    //Redis保存
                    key += responseType;
                    redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                    if (redis != null)
                        redis.Set(key, baseResponse);
                });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

            return resultStr;
        }

        /// <summary>
        /// 贷款还款明细查询
        /// </summary>
        /// <param name="intDtlQryReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string IntDtlQry([FromBody]IntDtlQryReq intDtlQryReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.IntDtlQry;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(intDtlQryReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.IntDtlQry, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };

                    //Redis保存
                    key += responseType;
                    redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                    if (redis != null)
                        redis.Set(key, baseResponse);
                });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

            return resultStr;
        }

        /// <summary>
        /// 贷款试算
        /// </summary>
        /// <param name="interestTrialReq">请求参数</param>
        /// <returns></returns>
        [HttpPost]
        public string InterestTrial([FromBody]InterestTrialReq interestTrialReq)
        {
            string resultStr = string.Empty;
            var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewLifeRedisHelper redis;
            SPDBankAPIType sPDBankAPIType = SPDBankAPIType.InterestTrial;
            int BankAPIType = (int)sPDBankAPIType;
            string key = (int)SPDBank + "-" + BankAPIType + "-" + Now + "-"; ; //Redis key                                                                                                                                         //Redis key
            int code = 0; //http请求错误码
            byte responseType; //返回类型
            BaseLog log = new BaseLog //日志对象
            {
                DateTime = Now,
                BankName = SPDBank.GetDescription(),
                APICode = BankAPIType,
                APIName = sPDBankAPIType.GetDescription()
            };
            try
            {
                var header = GetHeaderSign(interestTrialReq, out string dataRequest);
                resultStr = HttpClientHelper.POSTRequest(SPDBankConfig.InterestTrial, dataRequest, header, (statusCode, result) =>
                {
                    code = (int)statusCode;
                    responseType = code == Code ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        ResponseType = responseType,
                        DateTime = Now
                    };

                    //Redis保存
                    key += responseType;
                    redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.RespDb);
                    if (redis != null)
                        redis.Set(key, baseResponse);
                });
            }
            catch (Exception ex)
            {
                responseType = (byte)ResponseType.Fail;
                log.ErrorMsg = ex.Message;
                key += responseType;
            }
            //保存日志
            redis = NewLifeRedisHelper.GetRedis(RedisConn, (byte)RedisDbNum.ErrorDb);
            if (redis != null)
                redis.Set(key, log);

            return resultStr;
        }



        #endregion

    }
}
