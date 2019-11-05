﻿using NLog;
using System;

namespace shuiyintong.Api
{
    /// <summary>
    /// NLog日志记录帮助类
    /// </summary>
    public class NLogHelper
    {
        public readonly static Logger _Logger = LogManager.GetCurrentClassLogger();

    }
}
