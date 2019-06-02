﻿using PM.Common.Ext;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PM.Service
{
    public abstract class BaseService<T> where T : class, new()
    {
        #region 属性字段
        private DbContextServer _context;
        public DbContextServer Context
        {
            get { return _context; }
            set { _context = value; }
        }

        private SqlSugarClient _db;
        internal SqlSugarClient Db
        {
            get { return _db; }
            private set { _db = value; }
        }

        private SimpleClient<T> _entityDB;
        internal SimpleClient<T> EntityDB
        {
            get { return _entityDB; }
            private set { _entityDB = value; }
        }

        public Action<Exception> OnDalError { get; set; }
        public Action<string, SugarParameter[]> OnDalLogExecuting { get; set; }
        public Action<string, SugarParameter[]> OnDalLogExecuted { get; set; }
        public Func<string, SugarParameter[], KeyValuePair<string, SugarParameter[]>> OnDalExecutingChangeSql { get; set; }
        #endregion

        #region 构造函数
        /// <summary>
        /// 功能描述:构造函数
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:30:54
        /// 任务编号:Soft
        /// </summary>
        /// <param name="blnIsAutoCloseConnection">是否自动关闭连接</param>
        public BaseService(bool blnIsAutoCloseConnection = true)
        {
            DbContextServer context = DbContextServer.GetDbContext(blnIsAutoCloseConnection);
            _context = context;
            _db = context.Db;
            _entityDB = context.GetEntityDB<T>(_db);
        }

        /// <summary>
        /// 功能描述:使用指定的DbContext初始化一个对象
        /// 作　　者:Test
        /// 创建日期:2018-05-28 17:31:57
        /// 任务编号:Soft
        /// </summary>
        /// <param name="context">DbContext</param>
        public BaseService(DbContextServer context)
        {
            _context = context;
            _db = context.Db;
            _entityDB = context.GetEntityDB<T>(_db);
        }
        #endregion

        #region 增

        /// <summary>
        /// 功能描述:插入数据
        /// 作　　者:Test
        /// 创建日期:2018-05-16 17:57:26
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strSql">Sql语句</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>是否成功</returns>
        public bool Insert(string strSql, SugarParameter[] parameters = null) => _db.Ado.ExecuteCommand(strSql, parameters) > 0;

        /// <summary>
        /// 功能描述:插入数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:43:06
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表</param>
        /// <returns>是否成功</returns>
        public bool Insert(params T[] entitys) => _entityDB.InsertRange(entitys);

        /// <summary>
        /// 功能描述:插入数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:43:06
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表</param>
        /// <returns>是否成功</returns>
        public bool Insert(List<T> entitys) => _entityDB.InsertRange(entitys);

        /// <summary>
        /// 功能描述:插入数据，返回自增列
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:44:52
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>自增ID</returns>
        public int InsertReturnIdentity(T entity) => _entityDB.InsertReturnIdentity(entity);
        #endregion

        #region 删
        /// <summary>
        /// 功能描述:删除指定实体
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:47:38
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>是否成功</returns>
        public bool Delete(T entity) => _entityDB.Delete(entity);

        /// <summary>
        /// 功能描述:删除数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:06:10
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>受影响行数</returns>
        public int Delete(T[] entitys) => _db.Deleteable<T>(entitys.ToList()).ExecuteCommand();

        /// <summary>
        /// 功能描述:删除数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:52:35
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <returns>是否成功</returns>
        public bool Delete(Expression<Func<T, bool>> whereExpression) => _entityDB.Delete(whereExpression);

        /// <summary>
        /// 功能描述:删除数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:02:37
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <returns>是否成功</returns>
        public bool Delete(string strWhere) => _db.Deleteable<T>().Where(strWhere).ExecuteCommand() > 0;

        /// <summary>
        /// 功能描述:删除数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:02:37
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <returns>是否成功</returns>
        public bool Delete(string strWhere, List<SugarParameter> lstParameters) => _db.Deleteable<T>().Where(strWhere, lstParameters).ExecuteCommand() > 0;

        /// <summary>
        /// 功能描述:根据ID删除
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:08:18
        /// 任务编号:Soft
        /// </summary>
        /// <param name="ids">主键列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>受影响行数</returns>
        public int DeleteByID(params object[] ids) => _db.Deleteable<T>().In(ids).ExecuteCommand();
        #endregion

        #region 改

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-16 17:57:26
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strSql">Sql语句</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>是否成功</returns>
        public bool Update(string strSql, SugarParameter[] parameters = null) => _db.Ado.ExecuteCommand(strSql, parameters) > 0;

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:28:27
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>是否成功</returns>
        public bool Update(T entity) => _entityDB.Update(entity);

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:28:27
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="entity">条件</param>
        /// <returns>是否成功</returns>
        public bool Update(T entity, string strWhere) => _db.Updateable(entity).Where(strWhere).ExecuteCommand() > 0;

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:28:27
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="entity">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <returns>是否成功</returns>
        public bool Update(T entity, string strWhere, List<SugarParameter> lstParameters) => _db.Updateable(entity).Where(strWhere, lstParameters).ExecuteCommand() > 0;

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:31:15
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>受影响行数</returns>
        public int Update(T[] entitys) => Update(entitys, null, null);

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-16 15:31:09
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="lstColumns">更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="lstIgnoreColumns">不更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <returns>受影响行数</returns>
        public int Update(T[] entitys, List<string> lstColumns, List<string> lstIgnoreColumns) => Update(entitys, lstColumns, lstIgnoreColumns, string.Empty);

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-16 15:31:47
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="lstColumns">更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="lstIgnoreColumns">不更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="strWhere">条件</param>
        /// <returns>受影响行数</returns>
        public int Update(T[] entitys, List<string> lstColumns, List<string> lstIgnoreColumns, string strWhere) => Update(entitys, lstColumns, lstIgnoreColumns, strWhere, null);

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-16 15:33:06
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="lstColumns">更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="lstIgnoreColumns">不更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">条件参数</param>
        /// <returns>受影响行数</returns>
        public int Update(T[] entitys, List<string> lstColumns, List<string> lstIgnoreColumns, string strWhere, List<SugarParameter> lstParameters)
        {
            IUpdateable<T> up = _db.Updateable(entitys);
            if (lstIgnoreColumns.IsNotNullOrEmpty())
                up = up.IgnoreColumns(it => lstIgnoreColumns.Contains(it));

            if (lstColumns.IsNotNullOrEmpty())
                up = up.UpdateColumns(it => lstColumns.Contains(it));

            if (!string.IsNullOrEmpty(strWhere))
                up = up.Where(strWhere, lstParameters);

            return up.ExecuteCommand();
        }

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-16 15:33:36
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="lstColumns">更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="lstIgnoreColumns">不更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="whereExpression">条件</param>
        /// <returns>受影响行数</returns>
        public int Update(T[] entitys, List<string> lstColumns, List<string> lstIgnoreColumns, Expression<Func<T, bool>> whereExpression)
        {
            IUpdateable<T> up = _db.Updateable(entitys);
            if (lstIgnoreColumns.IsNotNullOrEmpty())
                up = up.IgnoreColumns(it => lstIgnoreColumns.Contains(it));

            if (lstColumns.IsNotNullOrEmpty())
                up = up.UpdateColumns(it => lstColumns.Contains(it));

            if (whereExpression != null)
                up = up.Where(whereExpression);

            return up.ExecuteCommand();
        }

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:40:18
        /// 任务编号:Soft
        /// </summary>
        /// <param name="columns">修改的列</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <returns>是否成功</returns>
        public bool Update(Expression<Func<T, T>> columns, Expression<Func<T, bool>> whereExpression) => _entityDB.Update(columns, whereExpression);

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:43:35
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="lstColumns">更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="lstIgnoreColumns">不更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <returns>是否成功</returns>
        public bool Update(T entity, List<string> lstColumns, List<string> lstIgnoreColumns) => Update(entity, lstColumns, lstIgnoreColumns, string.Empty);

        /// <summary>
        /// 功能描述:修改指定的列和值
        /// 作　　者:Test
        /// 创建日期:2018-05-16 19:33:46
        /// 任务编号:Soft
        /// </summary>       
        /// <param name="strWhere">条件</param>
        /// <param name="lstSetValueExpression">列和值列表(如：it => it.Name == (it.Name + 1))</param>
        /// <returns>是否成功</returns>
        public bool Update(string strWhere, params Expression<Func<T, bool>>[] lstSetValueExpression) => Update(strWhere, null, lstSetValueExpression);

        /// <summary>
        /// 功能描述:修改指定的列和值
        /// 作　　者:Test
        /// 创建日期:2018-05-16 19:34:01
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <param name="lstSetValueExpression">列和值列表(如：it => it.Name == (it.Name + 1))</param>        
        /// <returns>是否成功</returns>
        public bool Update(string strWhere, List<SugarParameter> lstParameters, params Expression<Func<T, bool>>[] lstSetValueExpression)
        {
            IUpdateable<T> up = _db.Updateable<T>();
            if (lstSetValueExpression != null)
            {
                foreach (var item in lstSetValueExpression)
                    up = up.ReSetValue(item);
            }
            if (!string.IsNullOrEmpty(strWhere))
                up = up.Where(strWhere, lstParameters);

            return up.ExecuteCommand() > 0;
        }

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:43:35
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="lstColumns">更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="lstIgnoreColumns">不更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="strWhere">条件</param>
        /// <returns>是否成功</returns>
        public bool Update(T entity, List<string> lstColumns, List<string> lstIgnoreColumns, string strWhere)
        {
            IUpdateable<T> up = _db.Updateable(entity);
            if (lstIgnoreColumns.IsNotNullOrEmpty())
                up = up.IgnoreColumns(it => lstIgnoreColumns.Contains(it));

            if (lstColumns.IsNotNullOrEmpty())
                up = up.UpdateColumns(it => lstColumns.Contains(it));

            if (!string.IsNullOrEmpty(strWhere))
                up = up.Where(strWhere);

            return up.ExecuteCommand() > 0;
        }

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:43:35
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="lstColumns">更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="lstIgnoreColumns">不更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <returns>是否成功</returns>
        public bool Update(T entity, List<string> lstColumns, List<string> lstIgnoreColumns, string strWhere, List<SugarParameter> lstParameters)
        {
            IUpdateable<T> up = _db.Updateable(entity);
            if (lstIgnoreColumns.IsNotNullOrEmpty())
                up = up.IgnoreColumns(it => lstIgnoreColumns.Contains(it));

            if (lstColumns.IsNotNullOrEmpty())
                up = up.UpdateColumns(it => lstColumns.Contains(it));

            if (!string.IsNullOrEmpty(strWhere))
                up = up.Where(strWhere, lstParameters);

            return up.ExecuteCommand() > 0;
        }

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-15 10:10:53
        /// 任务编号:Soft
        /// </summary>
        /// <param name="实体">entity</param>
        /// <param name="lstColumns">更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="lstIgnoreColumns">不更新的列，如果为空则不做限制(lstColumns与lstIgnoreColumns互斥)</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <returns>是否成功</returns>
        public bool Update(T entity, List<string> lstColumns, List<string> lstIgnoreColumns, Expression<Func<T, bool>> whereExpression)
        {
            IUpdateable<T> up = _db.Updateable(entity);
            if (lstIgnoreColumns.IsNotNullOrEmpty())
                up = up.IgnoreColumns(it => lstIgnoreColumns.Contains(it));

            if (lstColumns.IsNotNullOrEmpty())
                up = up.UpdateColumns(it => lstColumns.Contains(it));

            if (whereExpression != null)
                up = up.Where(whereExpression);

            return up.ExecuteCommand() > 0;
        }

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-14 15:40:53
        /// 任务编号:Soft
        /// </summary>
        /// <param name="lstColumnValues">列，值</param>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <returns>是否成功</returns>
        public bool Update(Dictionary<string, object> lstColumnValues, string strWhere, List<SugarParameter> lstParameters)
        {
            IUpdateable<T> up = _db.Updateable<T>(lstColumnValues);
            if (!string.IsNullOrEmpty(strWhere))
                up = up.Where(strWhere, lstParameters);

            return up.ExecuteCommand() > 0;
        }

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-14 15:42:27
        /// 任务编号:Soft
        /// </summary>
        /// <param name="lstColumnValues">列，值</param>
        /// <param name="whereExpression">条件</param>
        /// <returns>是否成功</returns>
        public bool Update(Dictionary<string, object> lstColumnValues, Expression<Func<T, bool>> whereExpression)
        {
            IUpdateable<T> up = _db.Updateable<T>(lstColumnValues);
            if (whereExpression != null)
                up = up.Where(whereExpression);

            return up.ExecuteCommand() > 0;
        }
        #endregion

        #region 查
        /// <summary>
        /// 功能描述:数据条数
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">strWhere</param>
        /// <returns>数据条数</returns>
        public int Count(string strWhere) => _db.Queryable<T>().WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).Count();

        /// 功能描述:总共的数目
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:16:09
        /// 任务编号:Soft
        /// <param name="whereExpression">条件表达式</param>
        /// <returns>数据条数</returns>
        public int Count(Expression<Func<T, bool>> whereExpression) => _entityDB.Count(whereExpression);

        /// 功能描述:列的最大值
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:16:09
        /// 任务编号:Soft
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="fieldtype">列的属性</param>
        /// <returns>列最大值</returns>
        public int Max(Expression<Func<T, bool>> whereExpression, Expression<Func<T, int>> fieldtype) => _db.Queryable<T>().Where(whereExpression).Max(fieldtype);

        /// 功能描述:列的最大值
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:16:09
        /// 任务编号:Soft
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="fieldtype">列的属性</param>
        /// <returns>列最大值</returns>
        public double Max(Expression<Func<T, bool>> whereExpression, Expression<Func<T, double>> fieldtype) => _db.Queryable<T>().Where(whereExpression).Max(fieldtype);

        /// <summary>
        /// 功能描述:数据列的和
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="fieldtype">列属性</param>
        /// <returns>列的和</returns>
        public int Sum(Expression<Func<T, bool>> whereExpression, Expression<Func<T, int>> fieldtype) => _db.Queryable<T>().Where(whereExpression).Sum(fieldtype);

        /// <summary>
        /// 功能描述:数据列的和
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="fieldtype">列属性</param>
        /// <returns>列的和</returns>
        public double Sum(Expression<Func<T, bool>> whereExpression, Expression<Func<T, double>> fieldtype) => _db.Queryable<T>().Where(whereExpression).Sum(fieldtype);

        /// <summary>
        /// 功能描述:数据列的和
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="fieldtype">列属性</param>
        /// <returns>列的和</returns>
        public decimal Sum(Expression<Func<T, bool>> whereExpression, Expression<Func<T, decimal>> fieldtype) => _db.Queryable<T>().Where(whereExpression).Sum(fieldtype);

        /// <summary>
        /// 功能描述:查询所有数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 14:02:34
        /// 任务编号:Soft
        /// </summary>
        /// <returns>数据列表</returns>
        public IQueryable<T> SelectAllToQueryable() => _entityDB.GetList().AsQueryable();

        /// <summary>
        /// 功能描述:查询所有数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 14:02:34
        /// 任务编号:Soft
        /// </summary>
        /// <returns>数据列表</returns>
        public List<T> Query() => _entityDB.GetList();

        /// <summary>
        /// 功能描述:查询数据列表
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:39:11
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <returns>数据列表</returns>
        public List<T> Query(string strWhere) => _db.Queryable<T>().WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).ToList();

        /// <summary>
        /// 功能描述:查询数据列表
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:40:32
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">whereExpression</param>
        /// <returns>数据列表</returns>
        public List<T> Query(Expression<Func<T, bool>> whereExpression) => _entityDB.GetList(whereExpression);

        /// <summary>
        /// 功能描述:查询一个列表
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:13:55
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> Query(Expression<Func<T, bool>> whereExpression, string strOrderByFileds) => _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(whereExpression != null, whereExpression).ToList();

        /// <summary>
        /// 功能描述:查询一个列表
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:14:54
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> Query(string strWhere, string strOrderByFileds) => _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).ToList();

        /// <summary>
        /// 功能描述:查询一个列表
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:14:54
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> Query(
            string strWhere,
            List<SugarParameter> lstParameters,
            string strOrderByFileds) => _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(!string.IsNullOrEmpty(strWhere), strWhere, lstParameters).ToList();

        /// <summary>
        /// 功能描述:查询前N条数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:16:09
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="intTop">前N条</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> Query(
            Expression<Func<T, bool>> whereExpression,
            int intTop,
            string strOrderByFileds) => _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(whereExpression != null, whereExpression).Take(intTop).ToList();

        /// <summary>
        /// 功能描述:查询前N条数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:17:14
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="intTop">前N条</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> Query(
            string strWhere,
            int intTop,
            string strOrderByFileds) => _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).Take(intTop).ToList();

        /// <summary>
        /// 功能描述:查询前N条数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:17:14
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <param name="intTop">前N条</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> Query(
            string strWhere,
            List<SugarParameter> lstParameters,
            int intTop,
            string strOrderByFileds) => _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(!string.IsNullOrEmpty(strWhere), strWhere, lstParameters).Take(intTop).ToList();

        /// <summary>
        /// 功能描述:分页查询
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:27:17
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="intPageIndex">页码（下标0）</param>
        /// <param name="intPageSize">页大小</param>
        /// <param name="intTotalCount">数据总量</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> Query(
            Expression<Func<T, bool>> whereExpression,
            int intPageIndex,
            int intPageSize,
            ref int intTotalCount,
            string strOrderByFileds) => _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(whereExpression != null, whereExpression).ToPageList(intPageIndex, intPageSize, ref intTotalCount);

        /// <summary>
        /// 功能描述:分页查询
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:29:07
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="intPageIndex">页码（下标0）</param>
        /// <param name="intPageSize">页大小</param>
        /// <param name="intTotalCount">数据总量</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> Query(
          string strWhere,
          int intPageIndex,
          int intPageSize,
          ref int intTotalCount,
          string strOrderByFileds) => _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).ToPageList(intPageIndex, intPageSize, ref intTotalCount);

        /// <summary>
        /// 功能描述:分页查询
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:29:07
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <param name="intPageIndex">页码（下标0）</param>
        /// <param name="intPageSize">页大小</param>
        /// <param name="intTotalCount">数据总量</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> Query(
          string strWhere,
          List<SugarParameter> lstParameters,
          int intPageIndex,
          int intPageSize,
          ref int intTotalCount,
          string strOrderByFileds) => _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(!string.IsNullOrEmpty(strWhere), strWhere, lstParameters).ToPageList(intPageIndex, intPageSize, ref intTotalCount);

        /// <summary>
        /// 功能描述:根据ID查询一条数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:23:21
        /// 任务编号:Soft
        /// </summary>
        /// <param name="objId">id（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>数据实体</returns>
        public T QueryByID(object objId) => _db.Queryable<T>().InSingle(objId);

        /// <summary>
        /// 功能描述:根据ID查询一条数据
        /// 作　　者:Test
        /// 创建日期:2018-05-14 16:58:09
        /// 任务编号:Soft
        /// </summary>
        /// <param name="objId">id（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="blnUseCache">是否使用缓存</param>
        /// <param name="cacheDurationInSeconds">缓存超时时间（秒）</param>
        /// <returns>数据实体</returns>
        public T QueryByID(
            object objId,
            bool blnUseCache = false,
            int cacheDurationInSeconds = 2147483647) => _db.Queryable<T>().WithCacheIF(blnUseCache).InSingle(objId);

        /// <summary>
        /// 功能描述:根据ID查询数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:23:34
        /// 任务编号:Soft
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>数据实体列表</returns>
        public List<T> QueryByIDs(object[] lstIds) => _db.Queryable<T>().In(lstIds).ToList();

        /// <summary>
        /// 功能描述:根据ID查询一条数据
        /// 作　　者:Test
        /// 创建日期:2018-05-14 16:58:47
        /// 任务编号:Soft
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="blnUseCache">是否使用缓存</param>
        /// <param name="cacheDurationInSeconds">缓存超时时间（秒）</param>
        /// <returns>数据实体列表</returns>
        public List<T> QueryByIDs(
            object[] lstIds,
            bool blnUseCache = false,
            int cacheDurationInSeconds = 2147483647) => _db.Queryable<T>().WithCacheIF(blnUseCache).In(lstIds).ToList();

        /// <summary>
        /// 执行自定义sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<T> SqlQuery(string sql) => _db.Ado.SqlQuery<T>(sql);

        #region 查询实体
        /// <summary>
        /// 功能描述:查询一个实体
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:45:37
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="blnUseCache">是否使用缓存机制</param>
        /// <param name="lstParameters">缓存过期时长</param>
        /// <returns>实体</returns>
        public T QueryEntity(
            Expression<Func<T, bool>> whereExpression,
            bool blnUseCache = false,
            int cacheDurationInSeconds = 2147483647) => _db.Queryable<T>().WithCacheIF(blnUseCache, cacheDurationInSeconds).WhereIF(whereExpression != null, whereExpression).First();

        /// <summary>
        /// 功能描述:查询一个实体
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:45:44
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <param name="blnUseCache">是否使用缓存机制</param>
        /// <param name="lstParameters">缓存过期时长</param>
        /// <returns>实体</returns>
        public T QueryEntity(
            string strWhere,
            List<SugarParameter> lstParameters = null,
            bool blnUseCache = false,
            int cacheDurationInSeconds = 2147483647) => _db.Queryable<T>().WithCacheIF(blnUseCache, cacheDurationInSeconds).WhereIF(!string.IsNullOrEmpty(strWhere), strWhere, lstParameters).First();
        #endregion

        #region 查询集合
        /// <summary>
        /// 功能描述:查询一个列表
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:47:14
        /// 任务编号:Soft
        /// </summary>
        /// <param name="blnUseCache">是否使用缓存机制</param>
        /// <param name="lstParameters">缓存过期时长</param>
        /// <returns>返回值</returns>
        public List<T> QueryList(bool blnUseCache = false, int cacheDurationInSeconds = 2147483647) => _db.Queryable<T>().WithCacheIF(blnUseCache, cacheDurationInSeconds).ToList();

        /// <summary>
        /// 功能描述:查询一个列表
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:50:32
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="intTop">前N条数据</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <param name="blnUseCache">是否使用缓存机制</param>
        /// <param name="lstParameters">缓存过期时长</param>
        /// <returns>数据列表</returns>
        public List<T> QueryList(
            Expression<Func<T, bool>> whereExpression,
            int? intTop = null,
            string strOrderByFileds = null,
            bool blnUseCache = false,
            int cacheDurationInSeconds = 2147483647)
        {
            ISugarQueryable<T> q = _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(whereExpression != null, whereExpression);
            if (intTop.HasValue)
                q = q.Take(intTop.Value);

            return q.WithCacheIF(blnUseCache, cacheDurationInSeconds).ToList();
        }

        /// <summary>
        /// 功能描述:查询一个列表
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:52:17
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <param name="intTop">前N条数据</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <param name="blnUseCache">是否使用缓存机制</param>
        /// <param name="lstParameters">缓存过期时长</param>
        /// <returns>数据列表</returns>
        public List<T> QueryList(
            string strWhere,
            List<SugarParameter> lstParameters = null,
            int? intTop = null,
            string strOrderByFileds = null,
            bool blnUseCache = false,
            int cacheDurationInSeconds = 2147483647)
        {
            ISugarQueryable<T> q = _db.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds).WhereIF(!string.IsNullOrEmpty(strWhere), strWhere, lstParameters);
            if (intTop.HasValue)
                q = q.Take(intTop.Value);

            return q.WithCacheIF(blnUseCache, cacheDurationInSeconds).ToList();
        }
        #endregion

        #region 查询分页
        /// <summary>
        /// 条件查询列表  
        /// </summary>
        /// <param name="wheretj">委托条件表达式</param>
        /// <returns>数据列表</returns>
        public ISugarQueryable<T> QueryToSugarArry(Expression<Func<T, bool>> wheretj) => _db.Queryable<T>().Where(wheretj);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="wheretj">条件</param>
        /// <param name="pageSize">每页条数</param>
        /// <param name="pageindex">页索引</param>
        /// <param name="total">总共的数目</param>
        /// <returns>数据列表</returns>
        public ISugarQueryable<T> QueryToPage(Expression<Func<T, bool>> wheretj, out int total, int pageSize, int pageindex)
        {
            var PageData = _db.Queryable<T>().Where(wheretj);
            total = _db.Queryable<T>().Where(wheretj).Count();
            return PageData.Skip(pageSize * (pageindex - 1)).Take(pageSize);
        }

        /// <summary>
        /// 功能描述:分页查询
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:55:06
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="intTotalCount">数据总数</param>
        /// <param name="intPageIndex">当前页</param>
        /// <param name="intPageSize">页大小</param>
        /// <param name="lstParameters">参数</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> QueryPage(
         string strWhere,
         ref int intTotalCount,
         int intPageIndex = 0,
         int intPageSize = 20,
         List<SugarParameter> lstParameters = null,
         string strOrderByFileds = null) => _db.Queryable<T>()
                .OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
                .WhereIF(!string.IsNullOrEmpty(strWhere), strWhere, lstParameters)
                .ToPageList(intPageIndex, intPageSize, ref intTotalCount);

        /// <summary>
        /// 功能描述:分页查询
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:55:06
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="intTotalCount">数据总数</param>
        /// <param name="intPageIndex">当前页</param>
        /// <param name="intPageSize">页大小</param>
        /// <param name="lstParameters">参数</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        public List<T> QueryPage(
         Expression<Func<T, bool>> whereExpression,
         ref int intTotalCount,
         int intPageIndex = 0,
         int intPageSize = 20,
         string strOrderByFileds = null) => _db.Queryable<T>()
                .OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
                .WhereIF(whereExpression != null, whereExpression)
                .ToPageList(intPageIndex, intPageSize, ref intTotalCount);
        #endregion

        #region 注释
        ///// <summary>
        ///// 功能描述:查询Table
        ///// 作　　者:Test
        ///// 创建日期:2018-05-16 18:03:14
        ///// 任务编号:Soft
        ///// </summary>
        ///// <param name="strSql">strSql</param>
        ///// <param name="lstParameters">参数</param>
        ///// <returns>DataTable</returns>
        //public SqlSugar.DataTable QueryTable(string strSql, SugarParameter[] lstParameters = null)
        //{
        //    return _db.Ado.GetDataTable(strSql, lstParameters);
        //}

        ///// <summary>
        ///// 功能描述:查询DataSet
        ///// 作　　者:Test
        ///// 创建日期:2018-05-16 18:06:05
        ///// 任务编号:Soft
        ///// </summary>
        ///// <param name="strSql">strSql</param>
        ///// <param name="lstParameters">参数</param>
        ///// <returns>DataSet</returns>
        //public SqlSugar.DataSet QueryDataSet(string strSql, SugarParameter[] lstParameters = null)
        //{
        //    return _db.Ado.GetDataSetAll(strSql, lstParameters);
        //}        #endregion

        #endregion
        #endregion

        #region 事务
        /// <summary>
        /// 功能描述:开始事务
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:49:49
        /// 任务编号:Soft
        /// </summary>
        public void BeginTran() => _db.Ado.BeginTran();

        /// <summary>
        /// 功能描述:提交事务
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:49:57
        /// 任务编号:Soft
        /// </summary>
        public void CommitTran() => _db.Ado.CommitTran();

        /// <summary>
        /// 功能描述:回滚事务
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:50:01
        /// 任务编号:Soft
        /// </summary>
        public void RollbackTran() => _db.Ado.RollbackTran();
        #endregion

        #region 其他    
        /// <summary>
        /// 功能描述:获取数据库时间
        /// 作　　者:Test
        /// 创建日期:2018-05-09 19:41:31
        /// 任务编号:Soft
        /// </summary>
        /// <returns>返回值</returns>
        public DateTime GetDBTime() => _db.GetDate();

        /// <summary>
        /// 功能描述:清除表缓存
        /// 作　　者:Test
        /// 创建日期:2018-05-11 10:15:51
        /// 任务编号:Soft
        /// </summary>
        public void RemoveCache()
        {
            var cacheService = _db.CurrentConnectionConfig.ConfigureExternalServices.DataInfoCacheService;
            string tableName = _db.EntityMaintenance.GetTableName<T>();
            var keys = cacheService.GetAllKey<string>();
            if (keys != null && keys.Count() > 0)
            {
                foreach (var item in keys)
                {
                    if (item.ToLower().Contains("." + tableName.ToLower() + "."))
                    {
                        cacheService.Remove<string>(item);
                    }
                }
            }
        }

        /// <summary>
        /// 功能描述:关闭连接
        /// 作　　者:Test
        /// 创建日期:2018-05-28 17:37:16
        /// 任务编号:Soft
        /// </summary>
        public void CloseDB()
        {
            if (_context != null && _context.Db != null)
            {
                _context.Db.Close();
                _context.Db.Dispose();
            }
        }
        #endregion

        #region 事件
        ///// <summary>
        ///// 功能描述:Sql执行完发生
        ///// 作　　者:Test
        ///// 创建日期:2018-05-11 10:40:25
        ///// 任务编号:Soft
        ///// </summary>
        ///// <param name="sql">sql</param>
        ///// <param name="pars">pars</param>
        //public virtual void OnLogExecuted(string sql, SugarParameter[] pars)
        //{

        //}
        ///// <summary>
        ///// 功能描述:Sql执行前发生
        ///// 作　　者:Test
        ///// 创建日期:2018-05-11 10:40:25
        ///// 任务编号:Soft
        ///// </summary>
        ///// <param name="sql">sql</param>
        ///// <param name="pars">pars</param>
        //public virtual void OnLogExecuting(string sql, SugarParameter[] pars)
        //{

        //}
        /// <summary>
        /// 功能描述:执行SQL 错误时发生
        /// 作 者:Test
        /// 创建日期:2018-05-11 10:40:25
        /// 任务编号:Soft
        /// </summary>
        /// <param name = "ex" > 错误 </ param >
        //public virtual void OnError(Exception ex)
        //{

        //}

        ///// <summary>
        ///// 功能描述:SQL执行前 可以修改SQL
        ///// 作　　者:Test
        ///// 创建日期:2018-05-11 10:47:37
        ///// 任务编号:Soft
        ///// </summary>
        ///// <param name="sql">sql</param>
        ///// <param name="pars">pars</param>
        ///// <returns>返回值</returns>
        //public virtual KeyValuePair<string, SugarParameter[]> OnExecutingChangeSql(string sql, SugarParameter[] pars)
        //{
        //    return new KeyValuePair<string, SugarParameter[]>(sql, pars);
        //}
        #endregion

    }
}