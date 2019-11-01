using log4net.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shuiyintong.Api
{
    /// <summary>
    /// Log4
    /// </summary>
    public class LogRepository
    {
        /// <summary>
        /// Log4日志
        /// </summary>
        public static ILoggerRepository Repository { get; set; }
    }
}
