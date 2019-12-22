using NewLife.Caching;
using shuiyintong.DBUtils.Service;
using System;
using System.Collections.Generic;

namespace shuiyintong.DBUtils.IService
{
    public interface IRediServer
    {
        #region 库编号
        /// <summary>
        /// 设置库编号
        /// </summary>
        /// <param name="dbnum">库编号</param>
        /// <returns></returns>
        RediServer InitDB(short dbnum);
        #endregion

        #region Key操作
        /// <summary>
        /// 添加Key,设置key有效期
        /// </summary>
        /// <param name="key">Key键</param>
        /// <param name="value">值</param>
        /// <param name="expire">过期时间(-1:永不过期)</param>
        /// <returns></returns>
        bool Set<T>(string key, T value, int expire = -1);

        /// <summary>
        /// 对已添加的Key,设置key有效期
        /// </summary>
        /// <param name="key">Key键</param>
        /// <param name="expire">过期时间</param>
        /// <returns></returns>
        bool SetExpire(string key, TimeSpan expire);

        /// <summary>
        /// 批量设置key值
        /// </summary>
        /// <param name="values">键值对集合</param>
        /// <param name="expire">过期时间(-1:永不过期</param>
        /// <returns></returns>
        void SetAll<T>(IDictionary<string, T> values, int expire = -1);

        /// <summary>
        /// 是否含有Key
        /// </summary>
        /// <param name="key">Key键</param>
        /// <returns></returns>
        bool ContainsKey(string key);

        /// <summary>
        /// 获取单个Key值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get<T>(string key);

        /// <summary>
        /// 获取多个Key值
        /// </summary>
        /// <param name="keys">Key集合</param>
        /// <returns></returns>
        IDictionary<string, T> GetAll<T>(IEnumerable<string> keys);

        /// <summary>
        /// 获取Key的过期时间，单位是TimeSpan
        /// </summary>
        /// <param name="key">Key键</param>
        /// <returns></returns>
        TimeSpan GetExpire(string key);

        /// <summary>
        /// 设置新值并获取旧值，原子操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        T Replace<T>(string key, T value);

        /// <summary>
        /// 获取所有的Key
        /// </summary>
        /// <param name="key">检索关键字Key</param>
        /// <param name="count">批量数量</param>
        /// <returns></returns>
        IEnumerable<string> ScanKeys(string key, short count = 100);

        /// <summary>
        /// 删除一个或者多个key
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        bool DelKey(params string[] keys);

        /// <summary>
        /// Key原子自增
        /// </summary>
        /// <param name="key">Key键</param>
        /// <param name="value">自增值</param>
        /// <returns></returns>
        long Incr(string key, long value = 1);

        /// <summary>
        /// Key原子自减
        /// </summary>
        /// <param name="key">Key键</param>
        /// <param name="value">自减值，默认为1</param>
        /// <returns></returns>
        long Decr(string key, long value = 1);
        #endregion

        #region 管道批量操作
        /// <summary>
        /// 管道批量操作---有结果返回
        /// </summary>
        /// <param name="act"></param>
        object[] StartPipeline(Action<RedisClient> act);
        #endregion

    }
}
