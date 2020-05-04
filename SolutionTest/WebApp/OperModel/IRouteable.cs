using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.OperModel
{
    /// <summary>
    /// StartUp配置
    /// </summary>
    public interface IRouteable
    {
        IApplicationBuilder DoSomething();

    }
}
