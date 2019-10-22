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
