using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PM.Service.CacheSetting
{
    public class LoadCache
    {
        /// <summary>
        /// 缓存对象
        /// </summary>
        public static CacheModel Cache { get; set; } = new CacheModel();
        /// <summary>
        /// 路径
        /// </summary>
        public static string DataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Cache");

        private static CacheModel Load()
        {
            CacheModel cache = null;
            try
            {
                using (FileStream stream = File.OpenRead(Path.Combine(DataFolder, "Settings.dat")))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    cache = (CacheModel)formatter.Deserialize(stream);
                }
            }
            catch { cache = new CacheModel(); }

            return cache;
        }

        /// <summary>
        /// 保存缓存文件
        /// </summary>
        /// <returns></returns>
        private static bool Save()
        {
            try
            {
                if (!Directory.Exists(DataFolder))
                    Directory.CreateDirectory(DataFolder);
                using (FileStream stream = File.OpenWrite(Path.Combine(DataFolder, "Settings.dat")))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, Cache);
                }
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 加载缓存文件
        /// </summary>
        public static void LoadCaches() => Cache = Load();
        /// <summary>
        /// 保存缓存文件
        /// </summary>
        /// <returns></returns>
        public static bool SaveSettings() => Save();
    }
}
