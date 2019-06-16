using PM.Entity.AppSettings;
using System.Collections.Concurrent;
using System.Reflection;

namespace PM.Factory
{
    public class ServerFac
    {
        /// <summary>
        /// 程序集对象
        /// </summary>
        private static Assembly _assembly;
        static ServerFac() //加载程序集
        {
            if (_assembly == null)
                _assembly = Assembly.Load(Config.DBConfig.Assembly);
        }

        /// <summary>
        /// 对象键值对集合
        /// </summary>
        private static ConcurrentDictionary<string, object> ObjectDir = new ConcurrentDictionary<string, object>();

        /// <summary>
        /// 反射获取对象
        /// </summary>
        /// <param name="model">对象字符串</param>
        /// <returns></returns>
        public static object GetObject(string model)
        {
            return ObjectDir.GetOrAdd(model, mod =>
             {
                 return _assembly.CreateInstance(Config.DBConfig.Assembly + "." + Config.DBConfig.File + "." + mod);
             });
        }
    }
}