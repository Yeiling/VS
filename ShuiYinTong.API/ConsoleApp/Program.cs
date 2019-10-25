using Newtonsoft.Json;
using shuiyintong.Common;
using shuiyintong.DBUtils;
using shuiyintong.SPDB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using static shuiyintong.Common.Enums.HttpEnum;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ORM
            string conn = "Server=39.105.178.182,3588;Database=SYT_apiDB_Test;Uid=Test_sa;Pwd=data2018!";
            SqlSugarHelper.InitClient(conn).TableToEntity(@"F:\Project\shuiyintong.dbutils\SYT_apiDB_TestEntity", "shuiyintong.DBUtils.SYT_apiDB_TestEntity");
            //var lst = SqlSugarHelper.InitClient(conn).GetList<DM_DataApiType>();



            #endregion

            #region 数据请求
            ////请求报文体
            //string domain = "https://etest2.spdb.com.cn/spdb/uat/api";
            //string urlpath = "/corpAcct/acctInfoQry";
            //var s = new { acctNo = "982J9435180018000" };
            //string ClientId = "cf187337-c26d-49d6-ab98-524355fc8623";
            ////string Secret = "nS6uP3oO5wK4dY8uX4aN0tT7hH6rU8jU7oW6aE7aI6iV6qO4qD";
            //string Secret = "NmF0NS00MDkhLWFkYTctY2ZpNmNlMDUmZjk3MC43MjM3NDM4OTU1MzE3NzY1MC41";

            //////请求头
            //var ss = JsonConvert.SerializeObject(s);
            //var ssss = SPDBSignature.Sign(ss, Secret);
            //Dictionary<string, string> header = new Dictionary<string, string>
            //{
            //    { "X-SPDB-Client-Id", ClientId },
            //    { "X-SPDB-SIGNATURE", ssss }
            //};

            //var tt = HttpClientHelper.POSTRequest(domain + urlpath, ss, header);

            ////ConfigMgr.configBasePath = @"C:\Projects\shuiyintongApi\ConsoleApp\bin\Debug\netcoreapp2.1\Setting";
            ////ConfigMgr.init();
            ////ConfigMgr.GetValue("dd");
            #endregion


            Console.ReadKey();
        }


    }
}
