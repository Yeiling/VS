using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.AppSettingsFile
{
    /// <summary>
    /// 
    /// </summary>
    public class DBConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public int DBType { get; set; }
        /// <summary>
        /// 数据库链接地址
        /// </summary>
        public string DbConnection { get; set; }
    }
}
