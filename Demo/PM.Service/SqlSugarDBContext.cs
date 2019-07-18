using PM.Common.Ext;
using PM.Entity.AppSettings;
using SqlSugar;
using System;
using System.Collections.Concurrent;

namespace PM.Service
{
    /// <summary>
    /// 封装sqlSugarCore数据库上下文
    /// </summary>
    public class SqlSugarDBContext
    {
        #region 
        //写死---测试使用
        private static string Conn = "Database=yiibaidb;Data Source=192.168.56.101;User Id=root;Password=123456;pooling=false;CharSet=utf8;port=3306";
        //Config.DBConfig.Test; //正式默认连接库
        #endregion
        #region  
        internal SqlSugarClient SqlSugarClient { get; set; }
        internal SimpleClient SimpleClient { get; set; }
        #endregion

        #region 
        private static ConcurrentDictionary<string, SqlSugarDBContext> DBContextDir = new ConcurrentDictionary<string, SqlSugarDBContext>();
        #endregion

        #region 
        private SqlSugarDBContext() { }
        /// <summary>
        /// 自定义连接库
        /// </summary>
        /// <param name="ConnStr"></param>
        /// <param name="dbType"></param>
        private SqlSugarDBContext(string ConnStr, DbType dbType = DbType.MySql)
        {
            if (String.IsNullOrWhiteSpace(ConnStr))
                throw new ArgumentNullException("数据库连接字符串为空~");
            if (SqlSugarClient == null)
            {
                SqlSugarClient = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = ConnStr,
                    DbType = dbType,
                    IsAutoCloseConnection = true,
                    IsShardSameThread = true,
                });
                SimpleClient = SqlSugarClient.GetSimpleClient();
            }
        }
        /// <summary>
        /// 默认连接PM(MySql)库
        /// </summary>
        /// <param name="dbType"></param>
        private SqlSugarDBContext(DbType dbType = DbType.MySql)
        {
            if (String.IsNullOrWhiteSpace(Conn))
                throw new ArgumentNullException("数据库连接字符串为空~");
            if (SqlSugarClient == null)
            {
                SqlSugarClient = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = Conn,
                    DbType = dbType,
                    IsAutoCloseConnection = true,
                    IsShardSameThread = true,
                });
                SimpleClient = SqlSugarClient.GetSimpleClient();
            }
        }
        #endregion

        #region 
        /// <summary>
        /// 自定义链接数据库
        /// </summary>
        /// <param name="ConnStr">连接字符串</param>
        /// <param name="dbType">数据库类型</param>
        /// <returns></returns>
        public static SqlSugarDBContext GetDbContext(string ConnStr, DbType dbType = DbType.MySql)
        {
            return DBContextDir.GetOrAdd(ConnStr, str =>
             {
                 return new SqlSugarDBContext(str, dbType);
             });

            #region 注释
            //return DBContextDir.AddOrUpdate(ConnStr, str =>
            //{
            //    return new SqlSugarDBContext(str, dbType);
            //}, (strs, context) =>
            //{
            //    context = new SqlSugarDBContext(strs, dbType);
            //    return context;
            //}); 
            #endregion
        }
        /// <summary>
        /// 默认连接PM(MySql)库
        /// </summary>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public static SqlSugarDBContext GetDbContext(DbType dbType = DbType.MySql)
        {
            return DBContextDir.GetOrAdd(Conn, str =>
            {
                return new SqlSugarDBContext(str, dbType);
            });
        }
        #endregion

        #region 
        /// <summary>
        /// 创建实体数据处理对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public SimpleClient<T> GetEntityDB<T>() where T : class, new()
        {
            return SqlSugarClient.GetSimpleClient<T>();
        }
        /// <summary>
        /// 创建实体数据处理对象 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="db">SqlSugarClient对象</param>
        /// <returns></returns>
        public SimpleClient<T> GetEntityDB<T>(SqlSugarClient db) where T : class, new()
        {
            return new SimpleClient<T>(db);
        }

        #endregion

        #region 
        public T SqlSugarClientFun<T>(Func<SqlSugarClient, T> fun) => fun(SqlSugarClient);
        public void SqlSugarClientAct(Action<SqlSugarClient> act) => act(SqlSugarClient);

        public T SimpleClientFun<T>(Func<SimpleClient, T> fun) => fun(SimpleClient);
        public void SimpleClientAct(Action<SimpleClient> act) => act(SimpleClient);
        #endregion

        #region 
        /// <summary>
        /// 根据表生成实体
        /// </summary>
        /// <param name="strPath"></param>
        /// <param name="strNameSpace"></param>
        /// <param name="lstTableNames"></param>
        public void CreateClassFileByDBTalbe(string strPath, string strNameSpace = "PM.Entity.PMEntity",
           params string[] lstTableNames) => CreateClass(strPath, strNameSpace, lstTableNames);
        /// <summary>
        /// 根据表生成实体
        /// </summary>
        /// <param name="strPath"></param>
        /// <param name="strNameSpace"></param>
        /// <param name="lstTableNames"></param>
        private void CreateClass(string strPath, string strNameSpace, params string[] lstTableNames)
        {
            if (lstTableNames.IsNullOrEmpty())
                SqlSugarClient.DbFirst.CreateClassFile(strPath, strNameSpace);
            else
                SqlSugarClient.DbFirst.Where(lstTableNames).CreateClassFile(strPath, strNameSpace);
        }
        #endregion

        #region 
        /// <summary>
        /// 根据实体类生成数据库表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="blnBackupTable"></param>
        /// <param name="lstEntitys"></param>
        public void CreateTableByEntity<T>(bool blnBackupTable, params T[] lstEntitys) where T : class, new()
        {
            Type[] lstTypes = null;
            if (lstEntitys != null)
            {
                lstTypes = new Type[lstEntitys.Length];
                for (int i = 0; i < lstEntitys.Length; i++)
                {
                    T t = lstEntitys[i];
                    lstTypes[i] = typeof(T);
                }
            }
            CreateTableByEntity(blnBackupTable, lstTypes);
        }

        /// <summary>
        /// 根据实体类生成数据库表
        /// </summary>
        /// <param name="blnBackupTable"></param>
        /// <param name="lstEntitys"></param>
        public void CreateTableByEntity(bool blnBackupTable, params Type[] lstEntitys)
        {
            if (blnBackupTable)
                SqlSugarClient.CodeFirst.BackupTable().InitTables(lstEntitys);
            else
                SqlSugarClient.CodeFirst.InitTables(lstEntitys);
        }
        #endregion

    }
}