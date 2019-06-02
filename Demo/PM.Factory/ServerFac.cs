using PM.Entity.AppSettings;
using System.Reflection;

namespace PM.Factory
{
    public class ServerFac
    {
        /// <summary>
        /// 程序集对象
        /// </summary>
        private static Assembly _assembly;
        static ServerFac()
        {
            if (_assembly == null)
                _assembly = Assembly.Load(Config.DBConfig.Assembly);
        }

        /// <summary>
        /// 反射获取对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static object GetObject(string model) => _assembly.CreateInstance(Config.DBConfig.Assembly + "." + Config.DBConfig.File + "." + model);
    }
}
