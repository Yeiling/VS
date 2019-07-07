﻿using PM.Entity.AppSettings;
using SqlSugar;
using System;

namespace PM.Service
{
    public class DbContextServer
    {
        #region 属性字段

        #region 连接字段和属性
        /// <summary>
        /// 连接后台库字段属性--0默认连接对象
        /// </summary>
        private static string _connectionString = Config.DBConfig.Test;
        /// <summary>
        /// 连接字符串 by ZhiHe 2018-05-08 09:56:05   ---后台管理库连接字符
        /// </summary>
        public static string ConnectionString
        {
            get { return _connectionString; }
        }
        #endregion

        /// <summary>
        /// 数据库类型
        /// </summary>
        private static DbType _dbType = DbType.MySql;
        /// <summary>
        /// 数据库类型 by ZhiHe 2018-05-08 09:58:03
        /// </summary>
        public static DbType DbType
        {
            get { return _dbType; }
            set { _dbType = value; }
        }


        #region 后台管理SQLSugar对象和日志管理SQLSugar对象
        private SqlSugarClient _db;
        /// <summary>
        /// 数据连接对象 by ZhiHe 2018-05-08 10:00:14
        /// </summary>
        public SqlSugarClient Db
        {
            get { return _db; }
            private set { _db = value; }
        }
        #endregion

        #region 后台管理库和日志管理库上下文声明
        /// <summary>
        /// 数据库上下文实例(连接后台管理库---自动关闭连接)
        /// </summary>
        public static DbContextServer Context
        {
            get
            {
                return new DbContextServer();
            }
        }
        /// <summary>
        /// 数据库上下文实例(连接日志管理库---自动关闭连接)
        /// </summary>
        //public static DbContextServer AdDataContext
        //{
        //    get
        //    {
        //        return new DbContextServer(Settings.AppConfig.ZhiHeAdData);
        //    }
        //}
        /// <summary>
        /// 数据库上下文实例(连接错误日志管理库---自动关闭连接)
        /// </summary>
        //public static DbContextServer ErrorLogContext
        //{
        //    get
        //    {
        //        return new DbContextServer(Settings.AppConfig.ZhiHeErrorLog);
        //    }
        //}

        /// <summary>
        /// 数据库上下文实例(连接App日志管理库---自动关闭连接)
        /// </summary>
        //public static DbContextServer AppLogContext
        //{
        //    get
        //    {
        //        return new DbContextServer(Settings.AppConfig.ZhiHeAppLog);
        //    }
        //}

        /// <summary>
        /// 数据库上下文实例(连接计数器库---自动关闭连接)
        /// </summary>

        #endregion

        #endregion

        #region 构造函数
        /// <summary>
        /// 功能描述:构造函数---连接后台管理库
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 09:47:24
        /// 任务编号:Soft
        /// </summary>
        private DbContextServer()
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new ArgumentNullException("数据库连接字符串为空");

            //连接后台管理库对象
            _db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = _connectionString,
                DbType = _dbType,
                IsAutoCloseConnection = true,
                IsShardSameThread = true,

                #region
                //配置SlaveConnectionConfigs主从模式,所有的写入删除更新都走主库，查询走从库，事务内都走主库，HitRate表示权重 值越大执行的次数越高，如果想停掉连接可以把HitRate设为0
                //SlaveConnectionConfigs = new List<SlaveConnectionConfig>()
                //{
                //     new SlaveConnectionConfig() { HitRate=50, ConnectionString=BaseDBConfig.ZhiHeAdDataSqlServerString}
                //},
                #endregion
                ConfigureExternalServices = new ConfigureExternalServices()
                {
                    //DataInfoCacheService = new HttpRuntimeCache()
                },
                MoreSettings = new ConnMoreSettings()
                {
                    //IsWithNoLockQuery = true,
                    IsAutoRemoveDataCache = true
                }
            });
        }
        /// <summary>
        /// 功能描述:构造函数
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-28 17:23:19
        /// 任务编号:Soft
        /// </summary>
        /// <param name="blnIsAutoCloseConnection">是否自动关闭连接</param>
        private DbContextServer(bool blnIsAutoCloseConnection)
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new ArgumentNullException("数据库连接字符串为空");
            _db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = _connectionString,
                DbType = _dbType,
                IsAutoCloseConnection = blnIsAutoCloseConnection,
                IsShardSameThread = true,
                ConfigureExternalServices = new ConfigureExternalServices()
                {
                    // DataInfoCacheService = new HttpRuntimeCache()
                },
                MoreSettings = new ConnMoreSettings()
                {
                    //IsWithNoLockQuery = true,
                    IsAutoRemoveDataCache = true
                }
            });
        }

        //----------------------------自定义连接--------------------------
        /// <summary>
        /// 功能描述:构造函数---连接日志库
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 09:47:24
        /// 任务编号:Soft
        /// </summary>
        private DbContextServer(string Connstr, bool blnIsAutoCloseConnection = true)
        {
            if (string.IsNullOrEmpty(Connstr))
                throw new ArgumentNullException("数据库连接字符串为空");
            //连接日志库对象
            _db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Connstr,   //连接日志库
                DbType = _dbType,
                IsAutoCloseConnection = blnIsAutoCloseConnection,
                IsShardSameThread = true,

                #region
                //配置SlaveConnectionConfigs主从模式,所有的写入删除更新都走主库，查询走从库，事务内都走主库，HitRate表示权重 值越大执行的次数越高，如果想停掉连接可以把HitRate设为0
                //SlaveConnectionConfigs = new List<SlaveConnectionConfig>()
                //{
                //     new SlaveConnectionConfig() { HitRate=50, ConnectionString=BaseDBConfig.ZhiHeAdDataSqlServerString}
                //},
                #endregion
                ConfigureExternalServices = new ConfigureExternalServices()
                {
                    //DataInfoCacheService = new HttpRuntimeCache()
                },
                MoreSettings = new ConnMoreSettings()
                {
                    //IsWithNoLockQuery = true,
                    IsAutoRemoveDataCache = true
                }
            });
        }
        #endregion

        #region 实例方法
        /// <summary>
        /// 功能描述:获取数据库处理对象
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 09:46:06
        /// 任务编号:Soft
        /// </summary>
        /// <returns>返回值</returns>
        public SimpleClient<T> GetEntityDB<T>() where T : class, new()
        {
            return new SimpleClient<T>(_db);
        }
        /// <summary>
        /// 功能描述:获取数据库处理对象
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-09 09:17:43
        /// 任务编号:Soft
        /// </summary>
        /// <param name="db">db</param>
        /// <returns>返回值</returns>
        public SimpleClient<T> GetEntityDB<T>(SqlSugarClient db) where T : class, new()
        {
            return new SimpleClient<T>(db);
        }

        #region 根据数据库表生产实体类
        /// <summary>
        /// 功能描述:根据数据库表生产实体类
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 10:14:37
        /// 任务编号:Soft
        /// </summary>       
        /// <param name="strPath">实体类存放路径</param>
        public void CreateClassFileByDBTalbe(string strPath)
        {
            CreateClassFileByDBTalbe(strPath, "ZhiHe.Entity");
        }
        /// <summary>
        /// 功能描述:根据数据库表生产实体类
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 10:10:59
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        public void CreateClassFileByDBTalbe(string strPath, string strNameSpace)
        {
            CreateClassFileByDBTalbe(strPath, strNameSpace, null);
        }

        /// <summary>
        /// 功能描述:根据数据库表生产实体类
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 10:18:18
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        public void CreateClassFileByDBTalbe(string strPath, string strNameSpace, string[] lstTableNames)
        {
            CreateClassFileByDBTalbe(strPath, strNameSpace, lstTableNames, string.Empty);
        }

        /// <summary>
        /// 功能描述:根据数据库表生产实体类
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-09 15:38:22
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strPath">实体类存放路径</param>
        /// <param name="strNameSpace">命名空间</param>
        /// <param name="lstTableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        public void CreateClassFileByDBTalbe(string strPath, string strNameSpace, string[] lstTableNames, string strInterface, bool blnSerializable = false)
        {
            if (lstTableNames != null && lstTableNames.Length > 0)
            {

                _db.DbFirst.Where(lstTableNames).IsCreateDefaultValue().IsCreateAttribute().SettingClassTemplate(p => p = @"
{using}

namespace {Namespace}
{
    {ClassDescription}{SugarTable}" + (blnSerializable ? "[Serializable]" : "") + @"
    public partial class {ClassName}" + (string.IsNullOrEmpty(strInterface) ? "" : (" : " + strInterface)) + @"
    {
        public {ClassName}()
        { 
            {Constructor}
        }
            {PropertyName}
    }
}
").SettingPropertyTemplate(p => p = @"
            {SugarColumn}
            public {PropertyType} {PropertyName}
            {
                get
                {
                    return _{PropertyName};
                }
                set
                {
                    if(_{PropertyName}!=value)
                    {
                        base.SetValueCall(" + "\"{PropertyName}\",_{PropertyName}" + @");
                    }
                    _{PropertyName}=value;
                }
            }")
                    .SettingPropertyDescriptionTemplate(p => p = "      private {PropertyType}  _{PropertyName};\r\n" + p)
                    .SettingConstructorTemplate(p => p = "      this._{PropertyName} ={DefaultValue};")
                    .CreateClassFile(strPath, strNameSpace);
            }
            else
            {
                _db.DbFirst.IsCreateAttribute().IsCreateDefaultValue()
                    .SettingClassTemplate(p => p = @"
{using}

namespace {Namespace}
{
    {ClassDescription}{SugarTable}" + (blnSerializable ? "[Serializable]" : "") + @"
    public partial class {ClassName}" + (string.IsNullOrEmpty(strInterface) ? "" : (" : " + strInterface)) + @"
    {
        public {ClassName}()
        {
           {Constructor}
        }
           {PropertyName}
    }
}
").SettingPropertyTemplate(p => p = @"{SugarColumn}
            public {PropertyType} {PropertyName}
            {
                get
                {
                    return _{PropertyName};
                }
                set
                {
                    if(_{PropertyName}!=value)
                    {
                        base.SetValueCall(" + "\"{PropertyName}\",_{PropertyName}" + @");
                    }
                    _{PropertyName}=value;
                }
            }")
                    .SettingPropertyDescriptionTemplate(p => p = "          private {PropertyType} _{PropertyName};\r\n" + p)
                    .SettingConstructorTemplate(p => p = "              this._{PropertyName} ={DefaultValue};")
                    .CreateClassFile(strPath, strNameSpace);
            }

        }
        #endregion

        #region 根据实体类生成数据库表
        /// <summary>
        /// 功能描述:根据实体类生成数据库表
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 10:31:02
        /// 任务编号:Soft
        /// </summary>
        /// <param name="blnBackupTable">是否备份表</param>
        /// <param name="lstEntitys">指定的实体</param>
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
        /// 功能描述:根据实体类生成数据库表
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 10:31:14
        /// 任务编号:Soft
        /// </summary>
        /// <param name="blnBackupTable">是否备份表</param>
        /// <param name="lstEntitys">指定的实体</param>
        public void CreateTableByEntity(bool blnBackupTable, params Type[] lstEntitys)
        {
            if (blnBackupTable)
            {
                _db.CodeFirst.BackupTable().InitTables(lstEntitys); //change entity backupTable            
            }
            else
            {
                _db.CodeFirst.InitTables(lstEntitys);
            }
        }
        #endregion

        #endregion

        #region 静态方法

        /// <summary>
        /// 功能描述:获得一个DbContext
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-28 17:24:12
        /// 任务编号:Soft
        /// </summary>
        /// <param name="blnIsAutoCloseConnection">是否自动关闭连接（如果为false，则使用接受时需要手动关闭Db）</param>
        /// <returns>返回值</returns>
        public static DbContextServer GetDbContext(bool blnIsAutoCloseConnection = true) => new DbContextServer(blnIsAutoCloseConnection);

        /// <summary>
        /// 功能描述:设置初始化参数
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 10:02:32
        /// 任务编号:Soft
        /// </summary>
        /// <param name="strConnectionString">连接字符串</param>
        /// <param name="enmDbType">数据库类型</param>
        public static void Init(string strConnectionString, DbType enmDbType)
        {
            _connectionString = strConnectionString;
            _dbType = enmDbType;
        }
        public static void InitDB(string strConnectionString, DbType enmDbType)
        {
            _connectionString = strConnectionString;
            _dbType = enmDbType;
        }
        /// <summary>
        /// 功能描述:创建一个链接配置
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-09 09:03:33
        /// 任务编号:Soft
        /// </summary>
        /// <param name="blnIsAutoCloseConnection">是否自动关闭连接</param>
        /// <param name="blnIsShardSameThread">是否夸类事务</param>
        /// <returns>ConnectionConfig</returns>
        public static ConnectionConfig GetConnectionConfig(bool blnIsAutoCloseConnection = true, bool blnIsShardSameThread = false)
        {
            ConnectionConfig config = new ConnectionConfig()
            {
                ConnectionString = _connectionString,
                DbType = _dbType,
                IsAutoCloseConnection = blnIsAutoCloseConnection,
                ConfigureExternalServices = new ConfigureExternalServices()
                {
                    //DataInfoCacheService = new HttpRuntimeCache()
                },
                IsShardSameThread = blnIsShardSameThread
            };
            return config;
        }
        public static ConnectionConfig GetConnectionConfig(string conn, bool blnIsAutoCloseConnection = true, bool blnIsShardSameThread = false)
        {
            ConnectionConfig config = new ConnectionConfig()
            {
                ConnectionString = conn,
                DbType = _dbType,
                IsAutoCloseConnection = blnIsAutoCloseConnection,
                ConfigureExternalServices = new ConfigureExternalServices()
                {
                    //DataInfoCacheService = new HttpRuntimeCache()
                },
                IsShardSameThread = blnIsShardSameThread
            };
            return config;
        }

        /// <summary>
        /// 功能描述:获取一个自定义的DB
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 09:49:36
        /// 任务编号:Soft
        /// </summary>
        /// <param name="config">config</param>
        /// <returns>返回值</returns>
        public static SqlSugarClient GetCustomDB(ConnectionConfig config)
        {
            return new SqlSugarClient(config);
        }
        /// <summary>
        /// 功能描述:获取一个自定义的数据库处理对象
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-09 08:56:20
        /// 任务编号:Soft
        /// </summary>
        /// <param name="sugarClient">sugarClient</param>
        /// <returns>返回值</returns>
        public static SimpleClient<T> GetCustomEntityDB<T>(SqlSugarClient sugarClient) where T : class, new()
        {
            return new SimpleClient<T>(sugarClient);
        }
        /// <summary>
        /// 功能描述:获取一个自定义的数据库处理对象
        /// 作　　者:ZhiHe
        /// 创建日期:2018-05-08 09:50:32
        /// 任务编号:Soft
        /// </summary>
        /// <param name="config">config</param>
        /// <returns>返回值</returns>
        public static SimpleClient<T> GetCustomEntityDB<T>(ConnectionConfig config) where T : class, new()
        {
            SqlSugarClient sugarClient = GetCustomDB(config);
            return GetCustomEntityDB<T>(sugarClient);
        }
        #endregion

        #region 自定义上下文对象
        public static SqlSugarClient GetSqlSugarClient(string Connstr, bool blnIsAutoCloseConnection = true)
        {
            return GetCustomDB(GetConnectionConfig(Connstr, blnIsAutoCloseConnection));
        }
        #endregion
    }
}