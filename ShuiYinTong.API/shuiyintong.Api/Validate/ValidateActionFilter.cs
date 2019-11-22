using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLog;
using shuiyintong.Entity.HttpRequestResultEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using static shuiyintong.Entity.Enums.RespCodeEnum;

namespace shuiyintong.Api.Validate
{
    /// <summary>
    /// 请求参数属性验证(如:必填项，数值范围约定，正则表达式匹配等)---重写
    /// </summary>
    public class ValidateActionFilter : ActionFilterAttribute
    {
        ///// <summary>
        ///// 日志服务
        ///// </summary>
        //private readonly Logger nlog = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// 重写OnActionExecuting方法，统一定义验证
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var result = context.ModelState.Keys
                        .SelectMany(key => context.ModelState[key].Errors
                        .Select(x => new ValidateModel(key, x.ErrorMessage)))
                        .ToList();
                //封装参数验证失败对象
                BaseResponse<List<ValidateModel>> ParameterValidation = new BaseResponse<List<ValidateModel>>
                {
                    Code = 412,//参数验证失败码
                    ResponseType = (byte)ResponseType.Fail,
                    Data = result,
                    DateTime = DateTime.Now.ToString("yyyyMMddHHmmss"),
                    Msg = ResponseType.Fail.GetDescription()
                };
                context.Result = new ObjectResult(ParameterValidation);
                //nlog.Info(result.ToJson());
            }
        }

        /// <summary>
        /// 重写OnActionExecuted方法，统一对返回结果处理
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ObjectResult) //验证是否通过
                return;

            //异常没有办法处理，所以。。。。
        }
    }

}
