using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankFile
{
    /// <summary>
    /// 浦发银行文件上传请求类型
    /// </summary>
    public class SPDBankFileUpLoadReq
    {
        /// <summary>
        /// 上传的本地文件绝对路径
        /// </summary>
        [Required(ErrorMessage = "上传的本地文件绝对路径必填")]
        public string localFile { get; set; }
        /// <summary>
        /// 上传文件重命名(noname表示文件不变名)
        /// </summary>
        [Required(ErrorMessage = "上传文件重命名必填")]
        public string remoteFile { get; set; }
        /// <summary>
        /// 上传目的目录(nodir表示为业务根目录）
        /// </summary>
        [Required(ErrorMessage = "上传目的目录必填")]
        public string remotedir { get; set; }
        /// <summary>
        /// 上传文件传输id，不续传时可用noid表示不填该项
        /// </summary>
        public string transId { get; set; }
        /// <summary>
        /// 是否续传标志，1为续传，0为不续传
        /// </summary>
        public int transFlag { get; set; }
    }
}
