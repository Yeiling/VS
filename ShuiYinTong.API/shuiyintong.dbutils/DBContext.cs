using SqlSugar;

namespace shuiyintong.DBUtils
{
    public class DBContext<T> where T : class, new()
    {
        public SqlSugarClient SqlClient;
        public SimpleClient<T> SimpleClient;


        #region 单例模式
        private static DBContext<T> dBContext = null;
        private DBContext() { }
        public DBContext(string conn, DbType DBtype = DbType.SqlServer)
        {
            SqlClient = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = conn,
                DbType = DBtype,//设置数据库类型
                IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                InitKeyType = InitKeyType.Attribute, //从实体特性中读取主键自增列信息
                IsShardSameThread = true ///设为true相同线程是同一个SqlConnection
            });
            SimpleClient = SqlClient.GetSimpleClient<T>();
        }
        #endregion
        

        public static DBContext<T> GetDBContext(string conn, DbType DBtype = DbType.SqlServer)
        {
            if (dBContext == null)
                dBContext = new DBContext<T>(conn, DBtype);
            return dBContext;
        }

    }
}
