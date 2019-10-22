using NewLife.Caching;
using NewLife.Data;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace shuiyintong.DBUtils
{
    /// <summary>
    /// NewLifeRedis操作类
    /// </summary>
    public class NewLifeRedisHelper
    {

        private readonly Redis redis;


        private static ConcurrentDictionary<string, NewLifeRedisHelper> dicNewLifeRedisHelper = new ConcurrentDictionary<string, NewLifeRedisHelper>();


        private NewLifeRedisHelper(string serverIp, byte dbNum = 0)
        {
            redis = NewLifeRedisConnection.GetConnectionMultiplexer(serverIp, dbNum);
        }


        public static NewLifeRedisHelper GetRedis(string server, byte dbNum)
        {
            return dicNewLifeRedisHelper.GetOrAdd(server + "_" + dbNum, value =>
            {
                return new NewLifeRedisHelper(server, dbNum);
            });
        }

        /// <summary>
        /// Redis相关处理方法
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="func"></param>
        /// <returns></returns> 
        private T DbFunc<T>(Func<Redis, T> func)
        {
            return func(redis);
        }
        /// <summary>
        /// Redis相关处理方法
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns> 
        private void DbAction(Action<Redis> action)
        {
            action(redis);
        }


        /// <summary>
        /// 删除key
        /// </summary>
        /// <param name="key">redis key</param>
        /// <returns>是否删除成功</returns>
        public bool RemoveKey(params string[] keys)
        {
            return DbFunc(db => db.Remove(keys) > 0);
        }

        /// <summary>
        /// 设置key失效时间
        /// </summary>
        /// <param name="key">redis key</param>
        /// <returns>是否删除成功</returns>
        public bool SetExpire(IEnumerable<string> keys, TimeSpan timeSpan)
        {
            return DbFunc(db =>
            {
                try
                {
                    foreach (var key in keys)
                    {
                        db.SetExpire(key, timeSpan);
                    }
                    return true;
                }
                catch { return false; }
            });
        }

        /// <summary>
        /// 判断key是否存储
        /// </summary>
        /// <param name="key">redis key</param>
        /// <returns></returns>
        public bool ExistsKey(string key)
        {
            return DbFunc(db => db.ContainsKey(key));
        }

        /// <summary>
        /// 所有的Key数组
        /// </summary>
        /// <param name="key">redis key</param>
        /// <returns></returns>
        public string[] GetKeysToArry(string cmd, params object[] args)
        {
            return DbFunc(db => db.Execute<string[]>(rc =>
            {
                return rc.Execute<string[]>(cmd, args);
            }));
        }

        /// <summary>
        /// 所有的Key集合
        /// </summary>
        /// <param name="key">redis key</param>
        /// <returns></returns>
        public IEnumerable<string> KeysToList(string cmd, params object[] args)
        {
            return DbFunc(db => db.Execute<IEnumerable<string>>(rc =>
            {
                return rc.Execute<string[]>(cmd, args).ToList();
            }));
        }

        /// <summary>
        /// Excute执行命令
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public object[] Execute(string cmd, params object[] args)
        {
            return DbFunc(db => db.Execute<object[]>(rc =>
            {
                return rc.Execute<object[]>(cmd, args);
            }));
        }

        public object ExecuteSingle(string cmd, params object[] args)
        {
            try
            {
                return DbFunc(db => db.Execute(rc =>
                {
                    return rc.Execute(cmd, args);
                }));
            }
            catch
            {
                return false;
            }
        }

        public int RedisExecute(string cmd, params object[] args)
        {
            return DbFunc(db => db.Execute<int>(rc =>
            {
                return rc.Execute<int>(cmd, args);//.Execute(cmd, args);
            }));
        }

        /// <summary>
        /// object格式转换成string
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public string PacektToStr(object args)
        {
            return ((Packet)args).ToStr();
        }

        /// <summary>
        /// object[]数组转换成string集合
        /// </summary>
        /// <param name="args">参数---Scan</param>
        /// <param name="func">处理key的函数</param>
        /// <returns></returns>
        public List<string> PacektToArry(object args)
        {
            var temp = (object[])args;
            List<string> result = null;
            if (temp.Length > 0)
            {
                string tmp = null;
                result = new List<string>(temp.Length);
                for (int i = 0; i < temp.Length; i++)
                {
                    tmp = PacektToStr(temp[i]);
                    if (!string.IsNullOrWhiteSpace(tmp))
                        result.Add(tmp);
                }
            }
            return result;
        }


        /// <summary>
        /// key值自增
        /// </summary>
        public void IncrementDouble(string key, double value = 1)
        {
            DbAction(db => db.Increment(key, value));
        }

        public void IncrementLong(string key, long value = 1)
        {
            DbAction(db => db.Increment(key, value));
        }

        public double IncrementDoubleExt(string key, double value = 1)
        {
            return DbFunc(db => db.Increment(key, value));
        }

        public long IncrementLongExt(string key, long value = 1)
        {
            return DbFunc(db => db.Increment(key, value));
        }


        /// <summary>
        /// key值自减
        /// </summary>
        public void DecrementDouble(string key, double value = 1)
        {
            DbAction(db => db.Decrement(key, value));
        }

        public void DecrementLong(string key, long value = 1)
        {
            DbAction(db => db.Decrement(key, value));
        }

        public double DecrementExt(string key, double value = 1)
        {
            return DbFunc(db => db.Decrement(key, value));
        }

        public long DecrementExt(string key, long value = 1)
        {
            return DbFunc(db => db.Decrement(key, value));
        }


        /// <summary>
        /// 设置String(Key)单个实体项
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expire"></param>
        /// <returns></returns>
        public bool Set<T>(string key, T value, int expire = -1)
        {
            return DbFunc(db => db.Set<T>(key, value, expire));
        }

        /// <summary>
        /// 批量设置缓存项
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="expire"></param>
        public void SetAll<T>(IDictionary<string, T> values, int expire = -1)
        {
            DbAction(db => db.SetAll<T>(values, expire));
        }

        /// <summary>
        /// 设置Key过期时间
        /// </summary>
        /// <param name="key"></param>
        /// <param name="expire"></param>
        /// <returns></returns>
        public bool SetExpire(string key, TimeSpan expire)
        {
            return DbFunc(db => db.SetExpire(key, expire));
        }

        /// <summary>
        /// 依据key获取一个对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T Get<T>(string key)
        {
            return DbFunc(db => db.Get<T>(key));
        }

        /// <summary>
        /// 批量获取缓存项
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keys"></param>
        /// <returns></returns>
        public IDictionary<string, T> GetAll<T>(List<string> keys)
        {
            return DbFunc(db => db.GetAll<T>(keys));
        }

        /// <summary>
        ///  获取key缓存项有效期
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public TimeSpan GetExpire(string key)
        {
            return DbFunc(db => db.GetExpire(key));
        }

        /// <summary>
        /// 添加，已存在时不更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expire"></param>
        /// <returns></returns>
        public bool Add<T>(string key, T value, int expire = -1)
        {
            return DbFunc(db => db.Add(key, value, expire));
        }

        /// <summary>
        /// 设置新值，原子操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public T Replace<T>(string key, T value)
        {
            return DbFunc(db => db.Replace(key, value));
        }

        /// <summary>
        /// 开启管道模式---Redis客户端模式---可执行相关Execute命令
        /// </summary>
        /// <returns></returns>
        public RedisClient GetRedisClient()
        {
            return DbFunc(db => db.StartPipeline());
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="config"></param>
        public void Init(string config)
        {
            DbAction(db => db.Init(config));
        }

        /// <summary>
        /// 清空所有缓存项
        /// </summary>
        public void Clear()
        {
            DbAction(db => db.Clear());
        }

        /// <summary>
        /// 提交变更。处理某些残留在管道里的命令
        /// </summary>
        /// <returns></returns>
        public int Commit()
        {
            return DbFunc(db => db.Commit());
        }


        /// <summary>
        /// RedisList添加元素在后面
        /// </summary>
        public int ListAddRange<T>(string key, T value)
        {
            return DbFunc(db => db.Execute(r => r.Execute<Int32>("RPUSH", key, value), true));
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        public int ListBatchAddRange(string key, List<Object> value)
        {
            var args = new List<Object>
            {
                key
            };
            args.AddRange(value);
            return DbFunc(db => db.Execute(r => r.Execute<Int32>("RPUSH", args.ToArray()), true));
        }

        /// <summary>
        /// RedisList获取自定义元素
        /// </summary>
        public T[] GetListAll<T>(string key, int start = 0, int stop = -1)
        {
            return DbFunc(db => db.Execute(r => r.Execute<T[]>("LRANGE", key, start, stop), false));
        }

        /// <summary>
        /// RedisList获取key对应的元素个数
        /// </summary>
        public int GetListCount(string key)
        {
            return DbFunc(db => db.Execute(r => r.Execute<Int32>("LLEN", key), false));
        }

        /// <summary>
        /// RedisSet添加---默认去重
        /// </summary>
        public int SetAdd<T>(string key, T value)
        {
            return DbFunc(db => db.Execute(r => r.Execute<Int32>("SADD", key, value), true));
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        public int SetBatchAddRange(string key, List<Object> value)
        {
            var args = new List<Object>
            {
                key
            };
            args.AddRange(value);
            return DbFunc(db => db.Execute(r => r.Execute<Int32>("SADD", args.ToArray()), true));
        }

        /// <summary>
        /// RedisSet获取所有元素
        /// </summary>
        public T[] GetSetAll<T>(string key)
        {
            return DbFunc(db => db.Execute(r => r.Execute<T[]>("SMEMBERS", key), false));
        }

        /// <summary>
        /// RedisSet获取key对应的元素个数
        /// </summary>
        public int GetSetCount(string key)
        {
            return DbFunc(db => db.Execute(r => r.Execute<Int32>("SCARD", key), false));
        }

    }
}