namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 借据详细信息查看返回类型
    /// </summary>
    public class LnRcrdDtlQryResp : BaseResp
    {
        /// <summary>
        /// 平台号
        /// </summary>
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 客户号
        /// </summary>
        public string clientNo { get; set; }
        /// <summary>
        /// 贷款币种 01-人民币 12-英镑 13-港币 14-美元 15-瑞士法郎 18-新加坡元 21-瑞典克郎 22-丹麦克郎 23-挪威克郎 27-日元 28-加拿大元 29-澳大利亚元 38-欧元"
        /// </summary>
        public string loanCode { get; set; }
        /// <summary>
        /// 贷款形式 1-信用贷款 2-担保贷款 3-抵(质)押贷款 4-其它贷款
        /// </summary>
        public string loanMode { get; set; }
        /// <summary>
        /// 贷款用途
        /// </summary>
        public string loanUsageDsc { get; set; }
        /// <summary>
        /// 借据号 在线融资系统自动生成
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 借据起息日
        /// </summary>
        public string startIntDate { get; set; }
        /// <summary>
        /// 借据到期日
        /// </summary>
        public string dublEfctDate { get; set; }
        /// <summary>
        /// 发放金额 同提款金额
        /// </summary>
        public string dstrAmt { get; set; }
        /// <summary>
        /// 贷款入账账号
        /// </summary>
        public string loanInAcctNo { get; set; }
        /// <summary>
        /// 还款账号
        /// </summary>
        public string repayAcctNo { get; set; }
        /// <summary>
        /// 执行年利率 同产品定义的利率
        /// </summary>
        public string execYearIntRate { get; set; }
        /// <summary>
        /// 还款方式 1-利随本清 2-按月还息一次还本 京东上送
        /// </summary>
        public string repayMode { get; set; }
        /// <summary>
        /// 下次结息日期 
        /// </summary>
        public string nxtIntSetlDt { get; set; }
        /// <summary>
        /// 逾期计息方式 0-逾期利率 1-逾期罚息比例 2-协议违约利率
        /// </summary>
        public string odueIntActualMode { get; set; }
        /// <summary>
        /// 逾期罚息浮动比率 逾期计息方法选择1-逾期罚息时有效
        /// </summary>
        public string oduePnyIntFltRt { get; set; }
        /// <summary>
        /// 本金余额
        /// </summary>
        public string loanBal { get; set; }
        /// <summary>
        /// 贷款性质 0-正常 1-展期 2-一类逾期 3-二类逾期 4-呆滞 5-呆帐
        /// </summary>
        public string loanChartic { get; set; }
    }
}
