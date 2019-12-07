using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using shuiyintong.Entity.AppSettiongModel;
using shuiyintong.Entity.HttpRequestResultEntity;
using System;
using static shuiyintong.Entity.Enums.RespCodeEnum;

namespace shuiyintong.Api.Validate
{
    /// <summary>
    /// 权限过滤
    /// </summary>
    public class AuthFilterAttribute : IAuthorizationFilter
    {
        /// <summary>
        /// 权限验证方法，实现接口
        /// </summary>
        /// <param name="context"></param>
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string privateKeyFlag = "key";
            var HeaderKeys = context.HttpContext.Request.Headers.Keys;
            if (!HeaderKeys.Contains(privateKeyFlag))
            {
                BaseResponse<string> ParameterValidation = new BaseResponse<string>
                {
                    Code = 401,
                    ResponseType = (byte)ResponseType.Fail,
                    Data = "用户权限验证不通过，请联系管理员开通权限",
                    DateTime = DateTime.Now.ToString("yyyyMMddHHmmss"),
                    Msg = ResponseType.Fail.GetDescription()
                };
                context.Result = new ObjectResult(ParameterValidation);
            }
            else
            {
                context.HttpContext.Request.Headers.TryGetValue(privateKeyFlag, out StringValues privateKeyFlagKey);
                var url = context.HttpContext.Request.Path.ToString().Split("/");
                var bankControlItem = AppSettings.BankConfig.BankControllers.Find(r => r.Key == privateKeyFlagKey.ToString());
                if (bankControlItem == null || bankControlItem.Key.ToString() != privateKeyFlagKey || bankControlItem.Controller != url[1])
                {
                    BaseResponse<string> ParameterValidation = new BaseResponse<string>
                    {
                        Code = 401,
                        ResponseType = (byte)ResponseType.Fail,
                        Data = "权限验证不通过，请联系管理员开通权限",
                        DateTime = DateTime.Now.ToString("yyyyMMddHHmmss"),
                        Msg = ResponseType.Fail.GetDescription()
                    };
                    context.Result = new ObjectResult(ParameterValidation);
                }
            }

        }
    }
}
