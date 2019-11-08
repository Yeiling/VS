using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace shuiyintong.Api.Validate
{
    /// <summary>
    /// 请求返回结果验证---重写
    /// </summary>
    public class ValidateResultAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 请求执行
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context) => base.OnActionExecuting(context);
        /// <summary>
        /// 执行结果过滤(包含参数验证失败返回和请求)
        /// </summary>
        /// <param name="context"></param>
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result != null)
                return;
            var objectResult = context.Result as ObjectResult;
            context.Result = new OkObjectResult(new BaseResultModel(code: 200, result: objectResult.Value));
        }

    }
}
