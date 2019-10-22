namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 电子回单申请请求类型
    /// </summary>
    public class ElectRecptApplctionReq
    {
        /// <summary>
        /// 柜员流水号---必填
        /// </summary>
        public string tellerSeqno { get; set; }
        /// <summary>
        /// 账号---必填
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 核心日期---必填
        /// </summary>
        public string hostDate { get; set; }
        /// <summary>
        /// 电子邮件地址
        /// </summary>
        public string notifyEmail { get; set; }
        /// <summary>
        /// 传票组内序号---必填
        /// </summary>
        public string txnSeqNo { get; set; }

    }
}
