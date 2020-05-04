using System.Threading.Tasks;
using WebApiClient.Attributes;
using WebApiClient.Contexts;

namespace WebClient.FilterFile
{
    /// <summary>
    /// 全局过滤器
    /// </summary>
    public class ApiGlobalFilter : ApiActionFilterAttribute //IApiActionFilter
    {
        #region 标记属性

        /// <summary>
        /// 请求唯一标记
        /// </summary>
        private string ReqFlag { get; set; }
        private string Now { get; set; }
        #endregion

        /// <summary>
        /// 接口调用之前调用
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task OnBeginRequestAsync(ApiActionContext context)
        {
            //return null;
            return base.OnBeginRequestAsync(context);
        }

        /// <summary>
        /// 接口调用之后调用
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task OnEndRequestAsync(ApiActionContext context)
        {

            //return null;
            return base.OnEndRequestAsync(context);
        }
    }
}
