using NewLife.Caching;
using NewLife.Data;
using shuiyintong.DBUtils.IService;
using shuiyintong.Entity.AppSettiongModel;
using System;
using System.Collections.Generic;

namespace shuiyintong.DBUtils.Service
{
    /// <summary>
    /// Redis封装
    /// </summary>
    public class RediServer<T> : IRediServer<T>
    {
        /// <summary>
        /// Redis服务对象
        /// </summary>
        private Redis redis { get; set; }
        /// <summary>
        /// 服务器地址
        /// </summary>
        private string serverIp = AppSettings.RedisConfig.RedisConn;

        #region 构造函数
        public RediServer() : this(0)
        { }
        public RediServer(short db) => redis = redis == null ? Redis.Create(serverIp, db) : null;
        #endregion

        #region Redis库编号设置
        /// <summary>
        /// 设置库编号
        /// </summary>
        /// <param name="dbnum">默认是0号库</param>
        /// <returns></returns>
        public RediServer<T> InitDB(short dbnum = 0)
        {
            if (redis == null)
                redis = Redis.Create(serverIp, dbnum);
            else
                redis.Db = dbnum;

            return this;
        }
        #endregion

        #region Key
        /// <summary>
        /// 添加Key,设置key有效期
        /// </summary>
        /// <param name="key">Key键</param>
        /// <param name="value">值</param>
        /// <param name="expire">过期时间(-1:永不过期)</param>
        /// <returns></returns>
        public bool Set(string key, T value, int expire = -1) => redis.Set<T>(key, value, expire);

        /// <summary>
        /// 对已添加的Key,设置key有效期
        /// </summary>
        /// <param name="key">Key键</param>
        /// <param name="expire">过期时间</param>
        /// <returns></returns>
        public bool SetExpire(string key, TimeSpan expire) => redis.SetExpire(key, expire);

        /// <summary>
        /// 批量设置key值
        /// </summary>
        /// <param name="values">键值对集合</param>
        /// <param name="expire">过期时间(-1:永不过期</param>
        /// <returns></returns>
        public void SetAll(IDictionary<string, T> values, int expire = -1) => redis.SetAll<T>(values, -1);

        /// <summary>
        /// 是否含有Key
        /// </summary>
        /// <param name="key">Key键</param>
        /// <returns></returns>
        public bool ContainsKey(string key) => redis.ContainsKey(key);

        /// <summary>
        /// 获取单个Key值
        /// </summary>
        /// <param name="key">Key键</param>
        /// <returns></returns>
        public T Get(string key) => redis.Get<T>(key);

        /// <summary>
        /// 获取多个Key值
        /// </summary>
        /// <param name="keys">Key集合</param>
        /// <returns></returns>
        public IDictionary<string, T> GetAll(IEnumerable<string> keys) => redis.GetAll<T>(keys);

        /// <summary>
        /// 获取Key的过期时间，单位是TimeSpan
        /// </summary>
        /// <param name="key">Key键</param>
        /// <returns></returns>
        public TimeSpan GetExpire(string key) => redis.GetExpire(key);

        /// <summary>
        /// 设置新值并获取旧值，原子操作
        /// </summary>
        /// <param name="key">key键</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        public T Replace(string key, T value) => redis.Replace(key, value);

        /// <summary>
        /// 获取所有的Key
        /// </summary>
        /// <param name="key">检索关键字Key</param>
        /// <param name="count">批量数量</param>
        /// <returns></returns>
        public IEnumerable<string> ScanKeys(string key, short count = 100)
        {
            var redisClient = redis.StartPipeline();
            if (redisClient == null)
                return null;

            string flag = "0";
            object objPacket = null;
            object[] objPacketTemp1 = null;
            object[] objPacketTemp2 = null;
            List<string> result = new List<string>();
            while (true)
            {
                objPacket = redisClient.Execute("scan", flag, "match", key, "count", count);
                if (objPacket != null)
                {
                    objPacketTemp1 = (object[])objPacket;
                    if (objPacketTemp1 != null)
                    {
                        flag = ((Packet)objPacketTemp1[0]).ToStr();
                        objPacketTemp2 = ((object[])objPacketTemp1[1]);
                        if (objPacketTemp2.Length > 0)
                        {
                            for (int i = 0; i < objPacketTemp2.Length; i++)
                                result.Add(((Packet)objPacketTemp2[i]).ToStr());
                        }
                    }
                }
                if (flag == "0")
                    break;
            }

            redisClient.StopPipeline(false);
            redisClient.Reset();

            return result;
        }

        /// <summary>
        /// 删除一个或者keys
        /// </summary>
        /// <param name="keys">一个或者多个</param>
        /// <returns></returns>
        public bool DelKey(params string[] keys) => redis.Remove(keys) == keys.Length ? true : false;



        /// <summary>
        /// Key原子自增
        /// </summary>
        /// <param name="key">Key键</param>
        /// <param name="value">自增值,默认值1</param>
        /// <returns></returns>
        public long Incr(string key, long value = 1) => redis.Increment(key, value);

        /// <summary>
        /// Key原子自减
        /// </summary>
        /// <param name="key">Key键</param>
        /// <param name="value">自减值，默认为1</param>
        /// <returns></returns>
        public long Decr(string key, long value = 1) => redis.Decrement(key, value);

        #endregion


        /// <summary>
        /// 管道批量操作---要求结果
        /// </summary>
        /// <param name="act"></param>
        public object[] StartPipeline(Action<RedisClient> act)
        {
            object[] result = null;
            var redisClient = redis.StartPipeline(); //开启管道模式
            try
            {
                if (redisClient == null) //测试服务器联通性
                    return null;

                act(redisClient);
            }
            finally
            {
                if (redisClient != null)
                {
                    result = redisClient.StopPipeline(true);
                    redisClient.Reset();  //清楚遗留记录
                    redisClient.Quit(); //退出
                }
            }
            return result;
        }

    }
}
