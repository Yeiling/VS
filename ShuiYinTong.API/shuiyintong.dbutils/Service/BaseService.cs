using shuiyintong.DBUtils.IService;
using shuiyintong.Entity.AppSettiongModel;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace shuiyintong.DBUtils.Service
{
    /// <summary>
    /// 数据库操作泛型基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseService<T> : IBaseService<T> where T : class, new()
    {
        #region 属性字段
        /// <summary>
        /// 数据库链接字段
        /// </summary>
        private readonly string conn = AppSettings.DBConfig.DBConn;
        /// <summary>
        /// 数据库类型MySQL
        /// </summary>
        private readonly DbType dbType = DbType.MySql;

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        private SqlSugarClient DB { get; set; }
        /// <summary>
        /// 实体数据处理对象 
        /// </summary>
        private SimpleClient<T> EntityDB { get; set; }
        #endregion

        #region 构造函数
        public BaseService()
        {
            if (DB == null)
            {
                DB = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = conn,
                    DbType = dbType,//设置数据库类型
                    IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                    InitKeyType = InitKeyType.Attribute, //从实体特性中读取主键自增列信息
                    IsShardSameThread = true ///设为true相同线程是同一个SqlConnection
                });
            }
            EntityDB = DB.GetSimpleClient<T>();
        }
        #endregion

        #region 添加
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

        #region 删除
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

        #region 查询
        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <param name="id">主键id</param>
        /// <returns></returns>
        public T GetById(dynamic id) => EntityDB.GetById(id);
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
        public IEnumerable<T> QueryPage(
         Expression<Func<T, bool>> whereExpression,
         ref int TotalCount,
         int PageIndex = 1,
         int PageSize = 20,
         string strOrderByFileds = null)
        {
            return DB.Queryable<T>()
                .OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
                .WhereIF(whereExpression != null, whereExpression)
                .ToPageList(PageIndex, PageSize, ref TotalCount);
        }
        /// <summary>
        /// SQL 分页查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="TotalCount"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public IEnumerable<T> QueryPage(string sql, ref int TotalCount, int PageIndex = 1, int PageSize = 30)
        {
            var lst = DB.Ado.SqlQuery<T>(sql);
            if (lst == null)
            {
                TotalCount = 0;
                return null;
            }
            TotalCount = lst.Count;
            return lst.Skip((PageIndex - 1) * PageSize).Take(PageSize);
        }
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

        /// <summary>
        /// 根据主键，使用In条件查询
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public IEnumerable<T> SqlQueryIn(params object[] paras) => DB.Queryable<T>().In(paras).ToList();

        #endregion

        #region 修改
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
        /// <summary>
        /// 依据表达式批量修改更新自定义列
        /// </summary>
        /// <param name="exp">表达式</param>
        /// <param name="columns">列</param>
        /// <returns></returns>
        public bool Modefy(Expression<Func<T, bool>> exp, Expression<Func<T, T>> columns) => EntityDB.Update(columns, exp);
        #endregion

        #region 其他

        #endregion

    }
}
