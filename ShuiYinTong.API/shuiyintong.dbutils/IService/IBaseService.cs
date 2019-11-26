using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace shuiyintong.DBUtils.IService
{
    public interface IBaseService<T> where T : class, new()
    {
        #region 增
        /// <summary>
        /// 添加单个对象
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool AddOne(T entity);
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="entityArr"></param>
        /// <returns></returns>
        bool AddList(T[] entityArr);
        #endregion

        #region 删
        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteById(dynamic id);
        /// <summary>
        /// 根据自定义条件删除
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        bool DeleteList(Expression<Func<T, bool>> exp);
        /// <summary>
        /// 删除单个对象
        /// </summary>
        /// <param name="deleteObj"></param>
        /// <returns></returns>
        bool Delete(T deleteObj);
        #endregion

        #region 改
        /// <summary>
        /// 修改单个对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool ModefyOne(T model);
        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="entityArr"></param>
        /// <returns></returns>
        bool Modefylist(T[] entityArr);
        /// <summary>
        /// 根据条件自定义修改自定义的列
        /// </summary>
        /// <param name="exp"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        bool Modefy(Expression<Func<T, bool>> exp, Expression<Func<T, T>> columns);
        #endregion

        #region 查
        /// <summary>
        /// 主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(dynamic id);
        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <returns></returns>
        T GetSingle(Expression<Func<T, bool>> whereExpression);
        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        IEnumerable<T> GetList(Expression<Func<T, bool>> exp);
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="exp"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        IEnumerable<T> GetPageList(Expression<Func<T, bool>> exp, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <param name="intTotalCount"></param>
        /// <param name="intPageIndex"></param>
        /// <param name="intPageSize"></param>
        /// <param name="strOrderByFileds"></param>
        /// <returns></returns>
        List<T> QueryPage(
                Expression<Func<T, bool>> whereExpression,
                ref int intTotalCount,
                int intPageIndex = 0,
                int intPageSize = 20,
                string strOrderByFileds = null);
        /// <summary>
        /// 多条件查询 
        /// </summary>
        /// <returns></returns>
        ISugarQueryable<T> Queryable();
        /// <summary>
        /// SQL查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        IEnumerable<T> GetListBySQL(string sql);
        /// <summary>
        /// SQL查询动态类型数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="whereObj"></param>
        /// <returns></returns>
        IEnumerable<dynamic> SqlQueryDynamic(string sql, object whereObj = null);
        #endregion

    }
}
