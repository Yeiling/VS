using Microsoft.AspNetCore.Mvc;
using shuiyintong.Common;
using shuiyintong.Common.Extend;
using shuiyintong.DBUtils;
using shuiyintong.Entity;
using shuiyintong.Entity.SPDBankEntity.SPDBankReq;
using shuiyintong.SPDB;
using System;
using System.Collections.Generic;
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
        //public IBaseService<view_DM_Api_Amount> Api_AmountService { get; set; }
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
        public void AcctInfoQry([FromBody]AccountReq accountRequest)
        {
            if (accountRequest != null)
            {
                var header = GetHeaderSign(accountRequest, out string dataRequest);

                HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.AcctInfoQry, dataRequest, header, (statusCode, result) =>
                {
                    var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
                    var code = (int)statusCode;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        DateTime = Now
                    };
                    baseResponse.ResponseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    //日志
                    BaseLog log = new BaseLog
                    {
                        Code = code,
                        DateTime = Now,
                        API = "AcctInfoQry"
                    };
                    //Redis保存
                    string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.AccountInfo).ToString() + "-" + Now + "-";
                    NewLifeRedisHelper redis;
                    try
                    {
                        key += (byte)ResponseType.Success;
                        redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                        if (redis != null)
                            redis.Set(key, baseResponse);
                    }
                    catch (Exception ex)
                    {
                        log.ErrorMsg = ex.Message;
                        key += (byte)ResponseType.Fail;
                    }
                    //保存日志
                    redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                    if (redis != null)
                        redis.Set(key, log);
                });
            }
            else
                throw new Exception("获取账户信息AcctInfoQry方法发生异常！");
        }

        /// <summary>
        /// 查询账户信息
        /// </summary>
        /// <param name="acctInfoReq">请求参数</param>
        [HttpPost]
        public void AcctDtlInfoQry([FromBody]AcctDtlInfoQryReq acctInfoReq)
        {
            if (acctInfoReq != null)
            {
                var header = GetHeaderSign(acctInfoReq, out string dataRequest);

                HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.AcctDtlInfoQry, dataRequest, header, (statusCode, result) =>
                {
                    var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
                    var code = (int)statusCode;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        DateTime = Now
                    };
                    baseResponse.ResponseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    //日志
                    BaseLog log = new BaseLog
                    {
                        Code = code,
                        DateTime = Now,
                        API = "AcctDtlInfoQry"
                    };
                    //Redis保存
                    string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.AcctDtlInfoQry).ToString() + "-" + Now + "-";
                    NewLifeRedisHelper redis;
                    try
                    {
                        key += (byte)ResponseType.Success;
                        redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                        if (redis != null)
                            redis.Set(key, baseResponse);
                    }
                    catch (Exception ex)
                    {
                        log.ErrorMsg = ex.Message;
                        key += (byte)ResponseType.Fail;
                    }
                    //保存日志
                    redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                    if (redis != null)
                        redis.Set(key, log);
                });
            }
            else
                throw new Exception("获取账户信息查询AcctDtlInfoQry方法发生异常！");
        }

        /// <summary>
        /// 单笔划拨
        /// </summary>
        /// <param name="singleTransferReq">请求参数</param>
        [HttpPost]
        public void SingleTransfer([FromBody]SingleTransferReq singleTransferReq)
        {
            if (singleTransferReq != null)
            {
                var header = GetHeaderSign(singleTransferReq, out string dataRequest);

                HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.SingleTransfer, dataRequest, header, (statusCode, result) =>
                {
                    var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
                    var code = (int)statusCode;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        DateTime = Now
                    };
                    baseResponse.ResponseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    //日志
                    BaseLog log = new BaseLog
                    {
                        Code = code,
                        DateTime = Now,
                        API = "SingleTransfer"
                    };
                    //Redis保存
                    string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.SingleTransfer).ToString() + "-" + Now + "-";
                    NewLifeRedisHelper redis;
                    try
                    {
                        key += (byte)ResponseType.Success;
                        redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                        if (redis != null)
                            redis.Set(key, baseResponse);
                    }
                    catch (Exception ex)
                    {
                        log.ErrorMsg = ex.Message;
                        key += (byte)ResponseType.Fail;
                    }
                    //保存日志
                    redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                    if (redis != null)
                        redis.Set(key, log);
                });
            }
            else
                throw new Exception("单笔划拨SingleTransfer方法发生异常！");
        }

        /// <summary>
        /// 单笔划拨结果查询
        /// </summary>
        /// <param name="snglTrsfRstlQryReq">请求参数</param>
        [HttpPost]
        public void SnglTrsfRstlQryReq([FromBody]SnglTrsfRstlQryReq snglTrsfRstlQryReq)
        {
            if (snglTrsfRstlQryReq != null)
            {
                var header = GetHeaderSign(snglTrsfRstlQryReq, out string dataRequest);

                HttpClientHelper.POSTRequest(bankConfig.SPDBankConfig.SnglTrsfRstlQry, dataRequest, header, (statusCode, result) =>
                {
                    var Now = DateTime.Now.ToString("yyyyMMddHHmmss");
                    var code = (int)statusCode;
                    BaseResponse<string> baseResponse = new BaseResponse<string>
                    {
                        Code = code,
                        Data = result,
                        DateTime = Now
                    };
                    baseResponse.ResponseType = code == 200 ? (byte)ResponseType.Success : (byte)ResponseType.Fail;
                    //日志
                    BaseLog log = new BaseLog
                    {
                        Code = code,
                        DateTime = Now,
                        API = "SnglTrsfRstlQryReq"
                    };
                    //Redis保存
                    string key = ((int)BankType.SPDBank).ToString() + "-" + ((int)SPDBankAPIType.SnglTrsfRstlQry).ToString() + "-" + Now + "-";
                    NewLifeRedisHelper redis;
                    try
                    {
                        key += (byte)ResponseType.Success;
                        redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.RespDb);
                        if (redis != null)
                            redis.Set(key, baseResponse);
                    }
                    catch (Exception ex)
                    {
                        log.ErrorMsg = ex.Message;
                        key += (byte)ResponseType.Fail;
                    }
                    //保存日志
                    redis = NewLifeRedisHelper.GetRedis(bankConfig.DBConfig.RedisConn, (byte)RedisDbNum.ErrorDb);
                    if (redis != null)
                        redis.Set(key, log);
                });
            }
            else
                throw new Exception("单笔划拨结果SnglTrsfRstlQryReq方法发生异常！");
        }





        #endregion





    }
}
