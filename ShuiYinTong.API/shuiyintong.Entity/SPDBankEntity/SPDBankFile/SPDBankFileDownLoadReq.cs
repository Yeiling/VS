namespace shuiyintong.Entity.SPDBankEntity.SPDBankFile
{
    /// <summary>
    /// 浦发银行下载文件请求类型
    /// </summary>
    public class SPDBankFileDownLoadReq
    {
        /// <summary>
        /// 上传的本地文件绝对路径---必填
        /// </summary>
        public string localFile { get; set; }
        /// <summary>
        /// 上传文件重命名---必填(noname表示文件不变名）
        /// </summary>
        public string remoteFile { get; set; }
        /// <summary>
        /// 上传目的目录，nodir表示为业务根目录
        /// </summary>
        public string localdir { get; set; }
        /// <summary>
        /// 上传文件传输id，不续传时可用noid表示不填该项
        /// </summary>
        public string transId { get; set; }    
        /// <summary>
        /// 是否续传标志，1为续传，0为不续传
        /// </summary>
        public int transFlag { get; set; }
        /// <summary>
        /// 任务id(noTaskId表示taskId为空)
        /// </summary>
        public string taskid { get; set; }
    }
}
