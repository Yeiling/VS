using shuiyintong.Entity.SPDBankEntity.SPDBankFile;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace shuiyintong.SPDB
{
    /// <summary>
    /// 文档上传下载
    /// </summary>
    public class SPDBankFile
    {
        /// <summary>
        /// 上传
        /// </summary>
        [DllImport("WtpClient.dll", CharSet = CharSet.None)]
        static extern int wtpUpLoadfile(string localfile, string remotefile, string remotedir, string transId, int transflag, ref WTPC_ERR pErr);
        /// <summary>
        /// 下载
        /// </summary>
        [DllImport("WtpClient.dll", CharSet = CharSet.None)]
        static extern int wtpDownLoadfile(string remotefile, string localfile,  string localdir, string transId, int transflag, string taskid, ref WTPC_ERR pErr);

        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="localfile">上传的本地文件绝对路径</param>
        /// <param name="remotefile">上传文件重命名，noname表示文件不变名</param>
        /// <param name="remotedir">上传目的目录，nodir表示为业务根目录</param>
        /// <param name="transId">上传文件传输id，不续传时可用noid表示不填该项</param>
        /// <param name="transflag">是否续传标志，1为续传，0为不续传</param>
        /// <param name="pErr">错误信息</param>
        /// <returns></returns>
        public static bool UpLoadfile(string localfile, string remotefile, string remotedir, string transId, int transflag, ref WTPC_ERR pErr)
        {
            var transResult = wtpUpLoadfile(localfile, remotefile, remotedir, transId, transflag, ref pErr);
            if (Convert.ToBoolean(transResult))
                return true;

            return false;
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="remotefile">上传文件重命名，noname表示文件不变名</param>
        /// <param name="localfile">上传的本地文件绝对路径</param>
        /// <param name="remotedir">上传目的目录，nodir表示为业务根目录</param>
        /// <param name="transId">上传文件传输id，不续传时可用noid表示不填该项</param>
        /// <param name="transflag">是否续传标志，1为续传，0为不续传</param>
        /// <param name="taskid">任务id</param>
        /// <param name="pErr">错误信息</param>
        /// <returns></returns>
        public static bool DownLoadfile(string remotefile, string localfile, string localdir, string transId, int transflag, string taskid, ref WTPC_ERR pErr)
        {
            var transResult = wtpDownLoadfile(remotefile, localfile, localdir, transId, transflag, taskid, ref pErr);
            if (Convert.ToBoolean(transResult))
                return true;

            return false;
        }



        /*获取当前exe文件的绝对路径+文件名*/
        public static string GetFileName()
        {
            /*获取新的 Process 组件并将其与当前活动的进程关联的主模块的完整路径，包含文件名(进程名)
            因此如出现调试时显示的exe名称与可执行文件的exe名称不符属于正常现象*/
            string FileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

            string strTemp = FileName.Substring(FileName.LastIndexOf(@"\"), FileName.Length - FileName.LastIndexOf(@"\"));
            string strFileName = strTemp.Substring(1);
            return strFileName;
        }

    }
}
