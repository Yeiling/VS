using NewLife.Caching;
using shuiyintong.Common.BankConfig;
using shuiyintong.DBUtils.IService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace shuiyintong.DBUtils.Service
{
    /// <summary>
    /// Redis操作泛型基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RedisBaseService<T> : IRedisBaseService<T> where T : class, new()
    {
        #region MyRegion
        /// <summary>
        /// Rerdis链接字符串
        /// </summary>
        private readonly string RedisConn = AppSettings.BankConfig.DBConfig.RedisConn;
        /// <summary>
        /// Redis操作对象
        /// </summary>
        private readonly Redis redis;

        private RedisBaseService()
        { }
        private RedisBaseService(byte dbNum) => redis = Redis.Create(RedisConn, dbNum);
        /// <summary>
        /// 创建Redis服务对象
        /// </summary>
        /// <param name="dbNum">数据库编号</param>
        /// <returns></returns>
        public static RedisBaseService<T> Init(byte dbNum) => new RedisBaseService<T>(dbNum);

        #endregion


        public void DecrementDouble(string key, double value = 1) => redis.Decrement(key, value);

        public bool ExistsKey(string key) => redis.ContainsKey(key);


        public T Get(string key) => redis.Get<T>(key);

        public void Increment(string key, double value = 1) => redis.Increment(key, value);

        public bool RemoveKey(params string[] keys) => redis.Remove(keys) == keys.Length;

        public bool Set(string key, T value, int expire = -1) => redis.Set(key, value, expire);

        public bool SetExpire(string key, TimeSpan expire) => redis.SetExpire(key, expire);

        public bool SetExpire(IEnumerable<string> keys, TimeSpan timeSpan)
        {
            int num = 0;
            foreach (var key in keys)
            {
                SetExpire(key, timeSpan);
                num++;
            }
            if (num == keys.Count())
                return true;

            return false;
        }

    }
}
