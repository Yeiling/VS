using NewLife.Caching;
using System.Collections.Concurrent;

namespace shuiyintong.DBUtils
{
    public class NewLifeRedisConnection
    {

        public static ConcurrentDictionary<string, string> RedisConnection = new ConcurrentDictionary<string, string>();

 
        private static readonly ConcurrentDictionary<string, Redis> connectionCache = new ConcurrentDictionary<string, Redis>();

        public static Redis GetConnectionMultiplexer(string serverIp, byte dbNum = 0)
        {
            return connectionCache.GetOrAdd(serverIp + "_" + dbNum, value =>
            {
                return GetManager(serverIp, dbNum);
            });
        }


        private static Redis GetManager(string serverIp, byte dbNum = 0)
        {
            //激活FullRedis，否则Redis.Create会得到默认的Redis对象
            FullRedis.Register();
            return Redis.Create(serverIp, dbNum);
        }

    }
}
