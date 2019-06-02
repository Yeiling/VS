using PM.Entity.CacheEntity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PM.Service.CacheSetting
{
    /// <summary>
    /// 保存缓存设置
    /// </summary>
    public class SaveCache
    {
        /// <summary>
        /// 保存缓存设置
        /// </summary>
        public static void CacheAll()
        {
            //上下文对象
            var dBContext = SqlSugarDBContext.GetDbContext();

            DeptCache(dBContext); //保存dept信息
            //.....
        }

        /// <summary>
        /// 生成DeptModel缓存
        /// </summary>
        private static bool DeptCache(SqlSugarDBContext dBContext)
        {
            var list = GetCacheList<DeptModel>(dBContext, @"select * from dept");
            if (list.Count > 0)
                LoadCache.Cache.DeptModel = list;
            return LoadCache.SaveSettings();
        }


        /// <summary>
        /// 封装通用缓存方法1
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        private static List<T> GetCacheList<T>(SqlSugarDBContext dBContext, string sql) where T : class, new()
        {
            return dBContext.SqlSugarClient.Ado.SqlQuery<T>(sql);
        }

        /// <summary>
        /// 封装通用缓存方法2
        /// </summary>
        /// <param name="wherexp">条件表达式</param>
        /// <returns></returns>
        private static List<V> GetCacheList<V>(SqlSugarDBContext dBContext, Expression<Func<V, bool>> wherexp) where V : class, new()
        {
            return dBContext.SimpleClient.GetList<V>(wherexp);
        }

    }

}
