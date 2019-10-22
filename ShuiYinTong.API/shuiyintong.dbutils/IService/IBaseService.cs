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
        #endregion

        #region 改
        bool ModefyOne(T model);
        bool Modefylist(T[] entityArr);
        #endregion

        #region 查
        T GetById(dynamic id);
        IEnumerable<T> GetList(Expression<Func<T, bool>> exp);
        #endregion

    }
}
