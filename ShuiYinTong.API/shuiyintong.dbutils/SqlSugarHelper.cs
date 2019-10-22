using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace shuiyintong.DBUtils
{
    public class SqlSugarHelper
    {
        private static SqlSugarClient SqlClient;
        private static SimpleClient SimpleClient;

        private static SqlSugarHelper sqlSugarHelper = null;
        private SqlSugarHelper() { }
        public SqlSugarHelper(string conn, DbType DBtype = DbType.SqlServer)
        {
            SqlClient = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = conn,//"server=.;uid=sa;pwd=@jhl85661501;database=SqlSugar4XTest",
                DbType = DBtype,//设置数据库类型
                IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
            });
            SimpleClient = SqlClient.GetSimpleClient();
        }
        /// <summary>
        /// 链接数据库
        /// </summary>
        /// <param name="conn">链接字符串</param>
        /// <param name="DBtype">数据库类型</param>
        /// <returns></returns>
        public static SqlSugarHelper InitClient(string conn, DbType DBtype = DbType.SqlServer)
        {
            if (sqlSugarHelper == null)
                sqlSugarHelper = new SqlSugarHelper(conn, DBtype);

            return sqlSugarHelper;
        }

        private void SqlClientAct(Action<SqlSugarClient> act) => act(SqlClient);
        private void SqlClientAct<T>(Action<SqlSugarClient> act) => act(SqlClient);

        private T SqlClientFunc<T>(Func<SqlSugarClient, T> func) => func(SqlClient);

        private void SimpleClientAct(Action<SimpleClient> act) => act(SimpleClient);
        private void SimpleClientAct<T>(Action<SimpleClient> act) => act(SimpleClient);

        private T SimpleClientFunc<T>(Func<SimpleClient, T> func) => func(SimpleClient);



        public T GetById<T>(dynamic id) where T : class, new() => SimpleClientFunc<T>(sc => sc.GetById<T>(id));

        public IEnumerable<T> GetList<T>() where T : class, new() => SimpleClientFunc(sc => sc.GetList<T>());


        public void TableToEntity(string path, string nameSpaces) => SqlClientAct(sc => sc.DbFirst.CreateClassFile(path, nameSpaces));
    }
}
