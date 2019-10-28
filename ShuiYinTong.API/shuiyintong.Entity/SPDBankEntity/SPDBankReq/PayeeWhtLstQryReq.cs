namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 收款人白名单查询请求类型
    /// </summary>
    public class PayeeWhtLstQryReq
    {
        /// <summary>
        /// 三方签约账号---必填
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 状态--必填
        /// </summary>
        public string acctNoStatus { get; set; }
        /// <summary>
        /// 起始笔数--必填
        /// </summary>
        public string startNum { get; set; }

    }
}
