using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PM.Service
{
    public interface IBaseServer<T> where T : class, new()
    {
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
        bool Insert(string strSql, SugarParameter[] parameters = null);

        /// <summary>
        /// 功能描述:插入数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:43:06
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表</param>
        /// <returns>是否成功</returns>
        bool Insert(params T[] entitys);

        /// <summary>
        /// 功能描述:插入数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:43:06
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体集合列表</param>
        /// <returns>是否成功</returns>
        bool Insert(List<T> entitys);

        /// <summary>
        /// 功能描述:插入数据，返回自增列
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:44:52
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>自增ID</returns>
        int InsertReturnIdentity(T entity);
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
        bool Delete(T entity);

        /// <summary>
        /// 功能描述:删除数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:06:10
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>受影响行数</returns>
        int Delete(T[] entitys);

        /// <summary>
        /// 功能描述:删除数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:52:35
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <returns>是否成功</returns>
        bool Delete(Expression<Func<T, bool>> whereExpression);

        /// <summary>
        /// 功能描述:删除数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:02:37
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <returns>是否成功</returns>
        bool Delete(string strWhere);

        /// <summary>
        /// 功能描述:删除数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:02:37
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="lstParameters">参数</param>
        /// <returns>是否成功</returns>
        bool Delete(string strWhere, List<SugarParameter> lstParameters);

        /// <summary>
        /// 功能描述:根据ID删除
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:08:18
        /// 任务编号:Soft
        /// </summary>
        /// <param name="ids">主键列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>受影响行数</returns>
        int DeleteByID(params object[] ids);
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
        bool Update(string strSql, SugarParameter[] parameters = null);

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:28:27
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>是否成功</returns>
        bool Update(T entity);

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:28:27
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="entity">条件</param>
        /// <returns>是否成功</returns>
        bool Update(T entity, string strWhere);

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
        bool Update(T entity, string strWhere, List<SugarParameter> lstParameters);

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:31:15
        /// 任务编号:Soft
        /// </summary>
        /// <param name="entitys">实体列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>受影响行数</returns>
        int Update(T[] entitys);

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
        int Update(T[] entitys, List<string> lstColumns, List<string> lstIgnoreColumns);

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
        int Update(T[] entitys, List<string> lstColumns, List<string> lstIgnoreColumns, string strWhere);

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
        int Update(T[] entitys, List<string> lstColumns, List<string> lstIgnoreColumns, string strWhere, List<SugarParameter> lstParameters);

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
        int Update(T[] entitys, List<string> lstColumns, List<string> lstIgnoreColumns, Expression<Func<T, bool>> whereExpression);

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 10:40:18
        /// 任务编号:Soft
        /// </summary>
        /// <param name="columns">修改的列</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <returns>是否成功</returns>
        bool Update(Expression<Func<T, T>> columns, Expression<Func<T, bool>> whereExpression);

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
        bool Update(T entity, List<string> lstColumns, List<string> lstIgnoreColumns);

        /// <summary>
        /// 功能描述:修改指定的列和值
        /// 作　　者:Test
        /// 创建日期:2018-05-16 19:33:46
        /// 任务编号:Soft
        /// </summary>       
        /// <param name="strWhere">条件</param>
        /// <param name="lstSetValueExpression">列和值列表(如：it => it.Name == (it.Name + 1))</param>
        /// <returns>是否成功</returns>
        bool Update(string strWhere, params Expression<Func<T, bool>>[] lstSetValueExpression);

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
        bool Update(string strWhere, List<SugarParameter> lstParameters, params Expression<Func<T, bool>>[] lstSetValueExpression);

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
        bool Update(T entity, List<string> lstColumns, List<string> lstIgnoreColumns, string strWhere);

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
        bool Update(T entity, List<string> lstColumns, List<string> lstIgnoreColumns, string strWhere, List<SugarParameter> lstParameters);

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
        bool Update(T entity, List<string> lstColumns, List<string> lstIgnoreColumns, Expression<Func<T, bool>> whereExpression);

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
        bool Update(Dictionary<string, object> lstColumnValues, string strWhere, List<SugarParameter> lstParameters);

        /// <summary>
        /// 功能描述:修改数据
        /// 作　　者:Test
        /// 创建日期:2018-05-14 15:42:27
        /// 任务编号:Soft
        /// </summary>
        /// <param name="lstColumnValues">列，值</param>
        /// <param name="whereExpression">条件</param>
        /// <returns>是否成功</returns>
        bool Update(Dictionary<string, object> lstColumnValues, Expression<Func<T, bool>> whereExpression);
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
        int Count(string strWhere);

        /// <summary>
        /// 功能描述:数据条数
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <returns>数据条数</returns>
        int Count(Expression<Func<T, bool>> whereExpression);

        /// <summary>
        /// 功能描述:数据条数
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="fieldtype">列属性</param>
        /// <returns>列最大值</returns>
        int Max(Expression<Func<T, bool>> whereExpression, Expression<Func<T, int>> fieldtype);

        /// <summary>
        /// 功能描述:数据条数
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="fieldtype">列属性</param>
        /// <returns>列最大值</returns>
        double Max(Expression<Func<T, bool>> whereExpression, Expression<Func<T, double>> fieldtype);

        /// <summary>
        /// 功能描述:数据列的和
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="fieldtype">列属性</param>
        /// <returns>列的和</returns>
        int Sum(Expression<Func<T, bool>> whereExpression, Expression<Func<T, int>> fieldtype);

        /// <summary>
        /// 功能描述:数据列的和
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="fieldtype">列属性</param>
        /// <returns>列的和</returns>
        double Sum(Expression<Func<T, bool>> whereExpression, Expression<Func<T, double>> fieldtype);

        /// <summary>
        /// 功能描述:数据列的和
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="fieldtype">列属性</param>
        /// <returns>列的和</returns>
        decimal Sum(Expression<Func<T, bool>> whereExpression, Expression<Func<T, decimal>> fieldtype);

        /// <summary>
        /// 功能描述:数据条数
        /// 作　　者:Test
        /// 创建日期:2018-05-25 18:07:00
        /// 任务编号:Soft
        /// </summary>
        /// <returns>返回值</returns>
        IQueryable<T> SelectAllToQueryable();

        /// <summary>
        /// 功能描述:查询所有数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 14:02:34
        /// 任务编号:Soft
        /// </summary>
        /// <returns>数据列表</returns>
        List<T> Query();

        /// <summary>
        /// 功能描述:查询数据列表
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:39:11
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <returns>数据列表</returns>
        List<T> Query(string strWhere);

        /// <summary>
        /// 功能描述:查询数据列表
        /// 作　　者:Test
        /// 创建日期:2018-05-10 10:40:32
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">whereExpression</param>
        /// <returns>数据列表</returns>
        List<T> Query(Expression<Func<T, bool>> whereExpression);

        /// <summary>
        /// 功能描述:查询一个列表
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:13:55
        /// 任务编号:Soft
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        List<T> Query(Expression<Func<T, bool>> whereExpression, string strOrderByFileds);

        /// <summary>
        /// 功能描述:查询一个列表
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:14:54
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <returns>数据列表</returns>
        List<T> Query(string strWhere, string strOrderByFileds);

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
        List<T> Query(string strWhere, List<SugarParameter> lstParameters, string strOrderByFileds);

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
        List<T> Query(Expression<Func<T, bool>> whereExpression, int intTop, string strOrderByFileds);

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
        List<T> Query(string strWhere, int intTop, string strOrderByFileds);

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
        List<T> Query(string strWhere, List<SugarParameter> lstParameters, int intTop, string strOrderByFileds);

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
        List<T> Query(Expression<Func<T, bool>> whereExpression, int intPageIndex, int intPageSize, ref int intTotalCount, string strOrderByFileds);

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
        List<T> Query(
         string strWhere,
         int intPageIndex,
         int intPageSize,
         ref int intTotalCount,
         string strOrderByFileds);

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
        List<T> Query(
         string strWhere,
         List<SugarParameter> lstParameters,
         int intPageIndex,
         int intPageSize,
         ref int intTotalCount,
         string strOrderByFileds);

        /// <summary>
        /// 功能描述:根据ID查询一条数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:23:21
        /// 任务编号:Soft
        /// </summary>
        /// <param name="objId">id（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>数据实体</returns>
        T QueryByID(object objId);

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
        T QueryByID(
            object objId,
            bool blnUseCache = false,
            int cacheDurationInSeconds = 2147483647);

        /// <summary>
        /// 功能描述:根据ID查询数据
        /// 作　　者:Test
        /// 创建日期:2018-05-09 11:23:34
        /// 任务编号:Soft
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>数据实体列表</returns>
        List<T> QueryByIDs(object[] lstIds);

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
        List<T> QueryByIDs(
            object[] lstIds,
            bool blnUseCache = false,
            int cacheDurationInSeconds = 2147483647);

        /// <summary>
        /// 执行自定义sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        List<T> SqlQuery(string sql);

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
        T QueryEntity(
           Expression<Func<T, bool>> whereExpression,
           bool blnUseCache = false,
           int cacheDurationInSeconds = 2147483647);

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
        T QueryEntity(
           string strWhere,
           List<SugarParameter> lstParameters = null,
           bool blnUseCache = false,
           int cacheDurationInSeconds = 2147483647);
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
        List<T> QueryList(bool blnUseCache = false, int cacheDurationInSeconds = 2147483647);

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
        List<T> QueryList(
           Expression<Func<T, bool>> whereExpression,
           int? intTop = null,
           string strOrderByFileds = null,
           bool blnUseCache = false,
           int cacheDurationInSeconds = 2147483647);

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
        List<T> QueryList(
           string strWhere,
           List<SugarParameter> lstParameters = null,
           int? intTop = null,
           string strOrderByFileds = null,
           bool blnUseCache = false,
           int cacheDurationInSeconds = 2147483647);
        #endregion

        #region 查询分页
        /// <summary>
        /// 条件查询列表  
        /// </summary>
        /// <param name="wheretj">委托条件表达式</param>
        /// <returns>数据列表</returns>
        ISugarQueryable<T> QueryToSugarArry(Expression<Func<T, bool>> wheretj);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="wheretj">条件</param>
        /// <param name="pageSize">每页条数</param>
        /// <param name="pageindex">页索引</param>
        /// <param name="total">总共的数目</param>
        /// <returns>数据列表</returns>
        ISugarQueryable<T> QueryToPage(Expression<Func<T, bool>> wheretj, out int total, int pageSize, int pageindex);

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
        List<T> QueryPage(
        string strWhere,
        ref int intTotalCount,
        int intPageIndex = 1,
        int intPageSize = 20,
        List<SugarParameter> lstParameters = null,
        string strOrderByFileds = null);

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
        List<T> QueryPage(
        Expression<Func<T, bool>> whereExpression,
        ref int intTotalCount,
        int intPageIndex = 0,
        int intPageSize = 20,
        string strOrderByFileds = null);
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
        //SqlSugar.DataTable QueryTable(string strSql, SugarParameter[] lstParameters = null);


        ///// <summary>
        ///// 功能描述:查询DataSet
        ///// 作　　者:Test
        ///// 创建日期:2018-05-16 18:06:05
        ///// 任务编号:Soft
        ///// </summary>
        ///// <param name="strSql">strSql</param>
        ///// <param name="lstParameters">参数</param>
        ///// <returns>DataSet</returns>
        //SqlSugar.DataSet QueryDataSet(string strSql, SugarParameter[] lstParameters = null);

        #endregion
        #endregion

        #region 事务
        /// <summary>
        /// 功能描述:开始事务
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:49:49
        /// 任务编号:Soft
        /// </summary>
        void BeginTran();

        /// <summary>
        /// 功能描述:提交事务
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:49:57
        /// 任务编号:Soft
        /// </summary>
        void CommitTran();

        /// <summary>
        /// 功能描述:回滚事务
        /// 作　　者:Test
        /// 创建日期:2018-05-09 09:50:01
        /// 任务编号:Soft
        /// </summary>
        void RollbackTran();

        #endregion

        #region 其他
        /// <summary>
        /// 功能描述:获取数据库时间
        /// 作　　者:Test
        /// 创建日期:2018-05-09 19:41:31
        /// 任务编号:Soft
        /// </summary>
        /// <returns>返回值</returns>
        DateTime GetDBTime();

        /// <summary>
        /// 功能描述:清除表缓存
        /// 作　　者:Test
        /// 创建日期:2018-05-11 10:15:51
        /// 任务编号:Soft
        /// </summary>
        void RemoveCache();

        /// <summary>
        /// 功能描述:关闭连接
        /// 作　　者:Test
        /// 创建日期:2018-05-28 17:37:16
        /// 任务编号:Soft
        /// </summary>
        void CloseDB();
        #endregion

    }
}