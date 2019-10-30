using System;
using System.Collections.Generic;

namespace shuiyintong.DBUtils.IService
{
    public interface IRedisBaseService<T> where T : class, new()
    {
        #region Key
        /// <summary>
        /// 删除key
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        bool RemoveKey(params string[] keys);
        /// <summary>
        /// 设置单个key过期时间
        /// </summary>
        /// <param name="key"></param>
        /// <param name="expire"></param>
        /// <returns></returns>
        bool SetExpire(string key, TimeSpan expire);
        /// <summary>
        /// 批量设置过期时间
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        bool SetExpire(IEnumerable<string> keys, TimeSpan timeSpan);
        /// <summary>
        /// 是否存在Key值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool ExistsKey(string key);
        /// <summary>
        /// key自增
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void Increment(string key, double value = 1);
        /// <summary>
        /// key自减
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void DecrementDouble(string key, double value = 1);
        #endregion

        #region 小批量检索


        #endregion

        #region 对象操作
        /// <summary>
        /// 设置单个对象
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expire"></param>
        /// <returns></returns>
        bool Set(string key, T value, int expire = -1);
        /// <summary>
        /// key获取单个对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get(string key);
        #endregion

    }
}
