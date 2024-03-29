﻿using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 单笔划拨请求类型
    /// </summary>
    public class SingleTransferReq
    {
        /// <summary>
        /// 商户流水号
        /// </summary>
        [Required(ErrorMessage = "商户流水号必填")]
        public string merSeqno { get; set; }
        /// <summary>
        /// 商户日期时间
        /// </summary>
        [Required(ErrorMessage = "商户日期时间必填")]
        public string mercDtTm { get; set; }
        /// <summary>
        /// 行内行外标志
        /// </summary>
        [Required(ErrorMessage = "行内行外标志必填")]
        public string spdbFlag { get; set; }
        /// <summary>
        /// 账户类型
        /// </summary>
        [Required(ErrorMessage = "账户类型必填")]
        public string jdAcctType { get; set; }
        /// <summary>
        /// 汇路标志
        /// </summary>
        public string remitFlag { get; set; }
        /// <summary>
        /// 付款人账号
        /// </summary>
        [Required(ErrorMessage = "付款人账号必填")]
        public string payAcct { get; set; }
        /// <summary>
        /// 付款人名称
        /// </summary>
        [Required(ErrorMessage = "付款人名称必填")]
        public string payAcctName { get; set; }
        /// <summary>
        /// 收款人账号
        /// </summary>
        [Required(ErrorMessage = "收款人账号必填")]
        public string rcvAcct { get; set; }
        /// <summary>
        /// 收款人名称
        /// </summary>
        [Required(ErrorMessage = "收款人名称必填")]
        public string rcvAcctName { get; set; }
        /// <summary>
        /// 收款行行号
        /// </summary>
        public string rcvBankId { get; set; }
        /// <summary>
        /// 收款行行名
        /// </summary>
        public string rcvBankName { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        [Required(ErrorMessage = "金额必填")]
        public string transAmt { get; set; }
        /// <summary>
        /// 附言
        /// </summary>
        [Required(ErrorMessage = "附言必填")]
        public string attachInfo { get; set; }
        /// <summary>
        /// 交易摘要
        /// </summary>
        public string transDigest { get; set; }
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
        public string inttrId { get; set; }
        /// <summary>
        /// 款项用途
        /// </summary>
        public string fndUsg { get; set; }

    }
}
