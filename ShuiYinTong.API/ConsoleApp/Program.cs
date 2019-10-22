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
        public const int WTP_ERRSTR_LEN = 1024; /*错误信息描述*/

        [StructLayout(LayoutKind.Sequential)]
        public struct WTPC_ERR
        {
            public int tp_errno;
            public int sys_errno;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WTP_ERRSTR_LEN + 1)]
            public string errstr;
        }

        [DllImport("WtpClient.dll", CharSet = CharSet.None)]
        static extern int wtpUpLoadfile(string localfile, string remotefile, string remotedir, string transId, int transflag, ref WTPC_ERR pErr);

        static int i = 0;



        static void Main(string[] args)
        {
            #region ORM
            //string conn = "Server=39.105.178.182,3588;Database=SYT_DataManage;Uid=Test_sa;Pwd=data2018!";
            //SqlSugarHelper.InitClient(conn).TableToEntity(@"F:\Project\shuiyintong.Entity\SPDBankEntity\SYT_DataManageEntity", "shuiyintong.Entity.SPDBankEntity.SYT_DataManageEntity");
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


            #region 文件上传/下载

            //string localFileName = "";
            //string remoteFileName = "";
            //string remotedir = "";
            //string transId = "";

            //int transResult;

            //foreach (string item in args)
            //{
            //    i++;
            //}

            //if ((i != 5))
            //{
            //    string myFileName = GetFileName();

            //    Console.WriteLine("\n Usage:" + myFileName + " localFileName remoteFileName remoteDir transId transFlag \n");
            //    Console.WriteLine("\t localFileName:上传的本地文件绝对路径\n");
            //    Console.WriteLine("\t remoteFileName: 上传文件重命名，noname表示文件不变名\n");
            //    Console.WriteLine("\t remoteDir:      上传目的目录，nodir表示为业务根目录 \n");
            //    Console.WriteLine("\t transId:        上传文件传输id，不续传时可用noid表示不填该项 \n");
            //    Console.WriteLine("\t transFlag:      是否续传标志，1为续传，0为不续传 \n");
            //    Console.WriteLine("\t 举例: \n");
            //    Console.WriteLine("\t \t 不续传: " + myFileName + " E:\\测试文档.txt noname dir1/dir2 noid 0 \n");
            //    Console.WriteLine("\t \t 续传:   " + myFileName + " E:\\测试文档.txt noname dir1/dir2 363de810ada661e380001bb900001bb902e9 1 \n");
            //    return;
            //}

            //WTPC_ERR errMsg = new WTPC_ERR();

            //localFileName = args[0];

            //string remoteFileNameTemp = args[1].ToLower();
            //if (remoteFileNameTemp != "noname")
            //{
            //    remoteFileName = args[1];
            //}

            //string remotedirTemp = args[2].ToLower();
            //if (remotedirTemp != "nodir")
            //{
            //    remotedir = args[2];
            //}

            //string transIdTemp = args[3].ToLower();
            //if (transIdTemp != "noid")
            //{
            //    transId = args[3];
            //}

            //int transFlag = Convert.ToInt32(args[4]);

            //transResult = wtpUpLoadfile(localFileName, remoteFileName, remotedir, transId, transFlag, ref errMsg);

            //if (Convert.ToBoolean(transResult))
            //{
            //    Console.WriteLine("文件上传失败：\n");
            //    Console.WriteLine("错误信息: " + errMsg.errstr + " \n");

            //    return;
            //}
            #endregion


            Console.ReadKey();
        }

        /*获取当前exe文件的绝对路径+文件名*/
        public static string GetFileName()
        {
            /*获取新的 Process 组件并将其与当前活动的进程关联的主模块的完整路径，包含文件名(进程名)
            因此如出现调试时显示的exe名称与可执行文件的exe名称不符属于正常现象*/
            string FileName = Process.GetCurrentProcess().MainModule.FileName;

            string strTemp = FileName.Substring(FileName.LastIndexOf(@"\"), FileName.Length - FileName.LastIndexOf(@"\"));
            string strFileName = strTemp.Substring(1);
            return strFileName;
        }



    }
}
