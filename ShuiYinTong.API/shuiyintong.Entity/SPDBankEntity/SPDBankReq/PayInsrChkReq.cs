using shuiyintong.Entity.SPDBankEntity.SPDBankResp;
using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 支付指令登记请求类型
    /// </summary>
    public class PayInsrChkReq: BaseResp
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        [Required(ErrorMessage = "商户编号必填")]
        public string mrchId { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        [Required(ErrorMessage = "交易流水号必填")]
        public string tranSeqNo { get; set; }
        /// <summary>
        /// 商户日期时间
        /// </summary>
        [Required(ErrorMessage = "商户日期时间必填")]
        public string mrchDateTim { get; set; }
        /// <summary>
        /// 客户号
        /// </summary>
        [Required(ErrorMessage = "客户号必填")]
        public string clientNo { get; set; }
        /// <summary>
        /// 行内行外标志
        /// </summary>
        [Required(ErrorMessage = "行内行外标志必填")]
        public string inOutBankFlag { get; set; }
        /// <summary>
        /// 指令审批核心企业账号
        /// </summary>
        [Required(ErrorMessage = "指令审批核心企业账号必填")]
        public string insAprCrEpClntAtNo { get; set; }
        /// <summary>
        /// 指令审批核心企业中文名
        /// </summary>
        [Required(ErrorMessage = "指令审批核心企业中文名必填")]
        public string insAprCrEpCltChsNm { get; set; }
        /// <summary>
        /// 发起方
        /// </summary>
        [Required(ErrorMessage = "发起方必填")]
        public string ittChannelId { get; set; }
        /// <summary>
        /// 款项用途
        /// </summary>
        [Required(ErrorMessage = "款项用途必填")]
        public string fndUsg { get; set; }
        /// <summary>
        /// 汇路标志
        /// </summary>
        public string lnkRdFlg { get; set; }
        /// <summary>
        /// 付款人账号
        /// </summary>
        [Required(ErrorMessage = "付款人账号必填")]
        public string payerAcctNo { get; set; }
        /// <summary>
        /// 付款人名称
        /// </summary>
        [Required(ErrorMessage = "付款人名称必填")]
        public string payerName { get; set; }
        /// <summary>
        /// 收款人账号
        /// </summary>
        [Required(ErrorMessage = "收款人账号必填")]
        public string payeeAcctNo { get; set; }
        /// <summary>
        /// 收款人名称
        /// </summary>
        [Required(ErrorMessage = "收款人名称必填")]
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
        [Required(ErrorMessage = "金额必填")]
        public string amt { get; set; }
        /// <summary>
        /// 附言
        /// </summary>
        [Required(ErrorMessage = "附言必填")]
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
        /// 纯度
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

    }
}
