using log4net;
using log4net.Appender;
using log4net.Config;
using System;
using System.IO;

namespace shuiyintong.Api
{
    /// <summary>
    /// Log4net日志
    /// </summary>
    public class Log4Helper
    {
        /// <summary>
        /// 日志记录对象
        /// </summary>
        private static ILog logger;
        static Log4Helper()
        {
            if (logger == null)
            {
                //DebugAppender  AdoNetAppender
                var repository = LogManager.CreateRepository("NetCoreRepository");
                //log4net从log4net.config文件中读取配置信息
                XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
                //logger是写入数据库日志对象
                logger = LogManager.GetLogger(repository.Name, "logadonet");
            }
        }


        #region 写入日志到数据库

        /// <summary>
        /// 普通日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void Info(object message, Exception exception = null) => logger.Info(message, exception);

        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void Error(object message, Exception exception = null) => logger.Error(message, exception);

        /// <summary>
        /// 告警日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void Warn(string message, Exception exception = null) => logger.Warn(message, exception);

        #endregion


    }
}
