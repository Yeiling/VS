using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace shuiyintong.DBUtils.IService
{
    public interface IBaseService<T> where T : class, new()
    {
        #region 增
        bool AddOne(T entity);
        bool AddList(T[] entityArr);
        #endregion

        #region 删
        bool DeleteById(dynamic id);
        bool DeleteList(Expression<Func<T, bool>> exp);
        bool Delete(T deleteObj);
        #endregion

        #region 改
        bool ModefyOne(T model);
        bool Modefylist(T[] entityArr);
        bool Modefy(Expression<Func<T, bool>> exp, Expression<Func<T, T>> columns);
        #endregion

        #region 查
        T GetById(dynamic id);
        IEnumerable<T> GetList(Expression<Func<T, bool>> exp);
        IEnumerable<T> GetPageList(Expression<Func<T, bool>> exp, int pageIndex, int pageSize, ref int totalCount);
        List<T> QueryPage(
                Expression<Func<T, bool>> whereExpression,
                ref int intTotalCount,
                int intPageIndex = 0,
                int intPageSize = 20,
                string strOrderByFileds = null);
        IEnumerable<T> GetListBySQL(string sql);
        #endregion




    }
}
