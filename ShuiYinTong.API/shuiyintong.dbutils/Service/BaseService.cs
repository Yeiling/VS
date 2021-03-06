﻿using shuiyintong.DBUtils.IService;
using shuiyintong.Entity.AppSettiongModel;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace shuiyintong.DBUtils.Service
{
    public class BaseService<T> : IBaseService<T> where T : class, new()
    {
        #region 
        private readonly string conn = AppSettings.DBConfig.DBConn;
        private readonly DbType dbType = (DbType)AppSettings.DBConfig.DbType;

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        private SqlSugarClient DB { get; set; }
        /// <summary>
        /// 实体数据处理对象 
        /// </summary>
        private SimpleClient<T> EntityDB { get; set; }

        #endregion

        #region 
        public BaseService()
        {
            if (DB == null)
            {
                DB = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = conn,
                    DbType = dbType,
                    IsAutoCloseConnection = true,
                    InitKeyType = InitKeyType.Attribute,
                    IsShardSameThread = true
                });
            }
            EntityDB = DB.GetSimpleClient<T>();
        }
        #endregion

        #region 增
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
        #endregion

        #region 删
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
        /// 删除对象
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns></returns>
        public bool Delete(T Obj) => EntityDB.Delete(Obj);
        #endregion

        #region 改
        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="entityArr">对象数组</param>
        /// <returns></returns>
        public bool Modifylist(T[] entityArr) => EntityDB.UpdateRange(entityArr);

        /// <summary>
        /// 修改单个实体对象
        /// </summary>
        /// <param name="model">对象</param>
        /// <returns></returns>
        public bool ModifyOne(T model) => EntityDB.Update(model);

        /// <summary>
        /// 依据表达式批量修改更新自定义列
        /// </summary>
        /// <param name="exp">表达式</param>
        /// <param name="columns">列</param>
        /// <returns></returns>
        public bool Modify(Expression<Func<T, bool>> exp, Expression<Func<T, T>> columns) => EntityDB.Update(columns, exp);

        #endregion

        #region 查
        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <param name="id">主键id</param>
        /// <returns></returns>
        public T GetById(dynamic id) => EntityDB.GetById(id);

        /// <summary>
        /// 查询单个实体对象
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public T GetSingle(Expression<Func<T, bool>> exp) => EntityDB.GetSingle(exp);

        /// <summary>
        /// 条件查询集合对象
        /// </summary>
        /// <param name="exp">表达式</param>
        /// <returns></returns>
        public IEnumerable<T> GetList(Expression<Func<T, bool>> exp) => EntityDB.GetList(exp);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public IEnumerable<T> GetPageList(Expression<Func<T, bool>> exp, int pageIndex, int pageSize, ref int totalCount) => DB.Queryable<T>().Where(exp).ToPageList(pageIndex, pageSize, ref totalCount);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <param name="intTotalCount"></param>
        /// <param name="intPageIndex"></param>
        /// <param name="intPageSize"></param>
        /// <param name="strOrderByFileds"></param>
        /// <returns></returns>
        public List<T> QueryPage(
         Expression<Func<T, bool>> whereExpression,
         ref int intTotalCount,
         int intPageIndex = 0,
         int intPageSize = 20,
         string strOrderByFileds = null)
        {
            return DB.Queryable<T>()
                .OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
                .WhereIF(whereExpression != null, whereExpression)
                .ToPageList(intPageIndex, intPageSize, ref intTotalCount);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public ISugarQueryable<T> Queryable() => DB.Queryable<T>();

        /// <summary>
        /// SQL查询集合
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public IEnumerable<T> GetListBySQL(string sql) => DB.SqlQueryable<T>(sql).ToList();


        /// <summary>
        /// 动态类型
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="whereObj"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> SqlQueryDynamic(string sql, object whereObj = null) => DB.Ado.SqlQuery<dynamic>(sql, whereObj);

        #endregion

    }
}
