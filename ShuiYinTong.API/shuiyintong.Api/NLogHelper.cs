using NLog;
using System;

namespace shuiyintong.Api
{
    /// <summary>
    /// NLog日志记录帮助类
    /// </summary>
    public class NLogHelper
    {
        private readonly static Logger processLogger = LogManager.GetLogger("LMDBLog");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="createDate"></param>
        /// <param name="origin"></param>
        /// <param name="logLevel"></param>
        /// <param name="message"></param>
        /// <param name="stackTrace"></param>
        public static void Process(DateTime createDate, string origin, string logLevel, string message, string stackTrace)
        {
            LogEventInfo theEvent = new LogEventInfo(LogLevel.Info, "", message);
            theEvent.Properties["createDate"] = createDate;
            theEvent.Properties["origin"] = origin;
            theEvent.Properties["logLevel"] = logLevel;
            theEvent.Properties["message"] = message;
            theEvent.Properties["stackTrace"] = stackTrace;
            processLogger.Log(theEvent);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public static void Flush()
        {
            LogManager.Flush();
        }
    }
}
