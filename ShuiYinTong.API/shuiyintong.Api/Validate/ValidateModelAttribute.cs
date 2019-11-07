using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Linq;

namespace shuiyintong.Api.Validate
{
    /// <summary>
    /// 请求参数验证---重写
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
                        .Select(x => new ValidationError(key, x.ErrorMessage)))
                        .ToList();
                context.Result = new ObjectResult(result);
            }
        }
    }

    /// <summary>
    /// 验证错误类
    /// </summary>
    public class ValidationError
    {
        /// <summary>
        /// 请求类型属性字段
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; }
        /// <summary>
        /// 错误消息
        /// </summary>
        public string Message { get; }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="field"></param>
        /// <param name="message"></param>
        public ValidationError(string field, string message)
        {
            Field = field != string.Empty ? field : null;
            Message = message;
        }

    }

}
