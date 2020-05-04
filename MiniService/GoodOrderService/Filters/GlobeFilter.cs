using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodOrderService.Filters
{
    /// <summary>
    /// 过滤器
    /// </summary>
    public class GlobeFilter : IActionFilter
    {
        private ILogger<GlobeFilter> _logger;
        public GlobeFilter(ILogger<GlobeFilter> logger)
        {
            _logger = logger;
        }


        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

    }
}
