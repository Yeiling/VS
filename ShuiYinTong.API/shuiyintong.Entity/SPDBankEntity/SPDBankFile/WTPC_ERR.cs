using System.Runtime.InteropServices;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankFile
{
    /// <summary>
    /// 浦发银行文件上传下载错误信息对象
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WTPC_ERR
    {
        /// <summary>
        /// tp编码
        /// </summary>
        public int tp_errno;
        /// <summary>
        /// sys编码
        /// </summary>
        public int sys_errno;
        /// <summary>
        /// 错误消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
        public string errstr;
    };
}
