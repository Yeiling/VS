using SqlSugar;

namespace shuiyintong.DBUtils
{
    public class DBContext
    {
        public static SqlSugarClient SqlClient;

        public static DBContext dBContext;

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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="DBtype"></param>
        /// <returns></returns>
        public static SqlSugarClient GetDBContext(string conn, DbType DBtype = DbType.SqlServer)
        {
            if (dBContext == null)
                dBContext = new DBContext(conn, DBtype);

            return SqlClient;
        }
    }
}
