namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 支付指令明细查询返回类型
    /// </summary>
    public class PayInsrDtlQryResp : BaseResp
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        public string mrchId { get; set; }
        /// <summary>
        /// 商户流水号
        /// </summary>
        public string mrchSeqNo { get; set; }
        /// <summary>
        /// 商户交易日期
        /// </summary>
        public string tranDate { get; set; }
        /// <summary>
        /// 行内行外标志 1-行内 2-行外
        /// </summary>
        public string inOutBankFlag { get; set; }
        /// <summary>
        /// 指令审批核心企业账号
        /// </summary>
        public string insAprCrEpClntAtNo { get; set; }
        /// <summary>
        /// 指令审批核心企业中文名
        /// </summary>
        public string insAprCrEpCltChsNm { get; set; }
        /// <summary>
        /// 发起方 0-三方签约商户 1-核心企业
        /// </summary>
        public string ittChannelId { get; set; }
        /// <summary>
        /// 款项用途 1-受托支付  2-主动扣款
        /// </summary>
        public string fndUsg { get; set; }
        /// <summary>
        /// 汇路标志 1-超网 2-二代支付
        /// </summary>
        public string lnkRdFlg { get; set; }
        /// <summary>
        /// 付款人账号
        /// </summary>
        public string payerAcctNo { get; set; }
        /// <summary>
        /// 付款人名称
        /// </summary>
        public string payerName { get; set; }
        /// <summary>
        /// 收款人账号
        /// </summary>
        public string payeeAcctNo { get; set; }
        /// <summary>
        /// 收款人名称
        /// </summary>
        public string payeeName { get; set; }
        /// <summary>
        /// 收款行行号
        /// </summary>
        public string pyBrId { get; set; }
        /// <summary>
        /// 收款行行名
        /// </summary>
        public string payeeBranchName { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string amt { get; set; }
        /// <summary>
        /// 附言
        /// </summary>
        public string postscript { get; set; }
        /// <summary>
        /// 交易摘要
        /// </summary>
        public string @abstract{ get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string ordrNo { get; set; }
        /// <summary>
        /// 合同号
        /// </summary>
        public string contractNo { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string pdName { get; set; }
        /// <summary>
        /// CAS
        /// </summary>
        public string ctlAtnSvc { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public string brndNm { get; set; }
        /// <summary>
        /// 纯度 百分比
        /// </summary>
        public string purity { get; set; }
        /// <summary>
        /// 产品包装规格
        /// </summary>
        public string specDsc { get; set; }
        /// <summary>
        /// 物流包装方式
        /// </summary>
        public string crgWrpStl { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public string untPrc { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string splrName { get; set; }
        /// <summary>
        /// 支付指令状态
        /// </summary>
        public string insrSt { get; set; }
        /// <summary>
        /// 支付交易流水号
        /// </summary>
        public string tranSeqNo { get; set; }
        /// <summary>
        /// 指令创建时间
        /// </summary>
        public string insrCreateTimep { get; set; }
        /// <summary>
        /// 复核/拒绝/取消时间
        /// </summary>
        public string ivsDtTm { get; set; }

    }
}
