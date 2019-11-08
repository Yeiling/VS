using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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
    public class ValidateModelAttribute : ActionFilterAttribute
    {
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
                    DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
                };
                context.Result = new ObjectResult(ParameterValidation);
            }
        }
    }

    #region 验证错误类---注释掉
    ///// <summary>
    ///// 验证错误类
    ///// </summary>
    //public class ValidationError
    //{
    //    /// <summary>
    //    /// 请求类型属性字段
    //    /// </summary>
    //    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    //    public string Field { get; }
    //    /// <summary>
    //    /// 错误消息
    //    /// </summary>
    //    public string Message { get; }


    //    /// <summary>
    //    /// 构造函数
    //    /// </summary>
    //    /// <param name="field"></param>
    //    /// <param name="message"></param>
    //    public ValidationError(string field, string message)
    //    {
    //        Field = field != string.Empty ? field : null;
    //        Message = message;
    //    }
    //} 
    #endregion

}
