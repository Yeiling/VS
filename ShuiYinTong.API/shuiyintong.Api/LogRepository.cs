using log4net.Repository;

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
