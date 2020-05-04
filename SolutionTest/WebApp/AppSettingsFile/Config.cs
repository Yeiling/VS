using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.AppSettingsFile
{
    /// <summary>
    /// 
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 
        /// </summary>
        public static DBConfig DBConfig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static RedisConfig RedisConfig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static ServiceConfig ServiceConfig { get; set; }
    }

}
