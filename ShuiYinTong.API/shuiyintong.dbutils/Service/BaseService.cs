using shuiyintong.Common.BankConfig;
using shuiyintong.DBUtils.IService;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace shuiyintong.DBUtils.Service
{
    public class BaseService<T> : IBaseService<T> where T : class, new()
    {
        #region 属性字段
        private readonly string conn = AppSettings.BankConfig.DBConfig.DBConn;
        private readonly DbType dbType = DbType.SqlServer;

        /// <summary>
        /// 上下文对象
        /// </summary>
        private static DBContext<T> dBContext;
        /// <summary>
        /// 数据处理对象 
        /// </summary>
        private static SqlSugarClient DB;
        /// <summary>
        /// 实体数据处理对象 
        /// </summary>
        private static SimpleClient<T> EntityDB;


        #endregion

        #region 构造函数
        public BaseService()
        {
            if (dBContext == null)
            {
                dBContext = DBContext<T>.GetDBContext(conn, dbType);
                DB = dBContext.SqlClient;
                EntityDB = dBContext.SimpleClient;
            }
        }
        #endregion

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="entityArr">对象数组</param>
        /// <returns></returns>
        public bool AddList(T[] entityArr) => EntityDB.InsertRange(entityArr);
        /// <summary>
        /// 单个实体添加
        /// </summary>
        /// <param name="entity">对象</param>
        /// <returns></returns>
        public bool AddOne(T entity) => EntityDB.Insert(entity);


        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="id">主键id</param>
        /// <returns></returns>
        public bool DeleteById(dynamic id) => EntityDB.DeleteById(id);
        /// <summary>
        /// 删除单个实体
        /// </summary>
        /// <param name="exp">表达式</param>
        /// <returns></returns>
        public bool DeleteList(Expression<Func<T, bool>> exp) => EntityDB.Delete(exp);


        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <param name="id">主键id</param>
        /// <returns></returns>
        public T GetById(dynamic id) => EntityDB.GetById(id);
        /// <summary>
        ///条件查询集合对象
        /// </summary>
        /// <param name="exp">表达式</param>
        /// <returns></returns>
        public IEnumerable<T> GetList(Expression<Func<T, bool>> exp) => EntityDB.GetList(exp);


        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="entityArr">对象数组</param>
        /// <returns></returns>
        public bool Modefylist(T[] entityArr) => EntityDB.UpdateRange(entityArr);
        /// <summary>
        /// 修改单个实体对象
        /// </summary>
        /// <param name="model">对象</param>
        /// <returns></returns>
        public bool ModefyOne(T model) => EntityDB.Update(model);


    }
}
