using System.Collections.Generic;

namespace shuiyintong.Entity.SPDBankEntity.SPDResp
{
    /// <summary>
    /// 三方解约返回类型
    /// </summary>
    public class FncThdCnclResp
    {
        /// <summary>
        /// 返回信息
        /// </summary>
        public string statusMsg { get; set; }
        /// <summary>
        /// 返回状态码
        /// </summary>
        public string statusCode { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string transNo { get; set; }
        /// <summary>
        /// 客户号
        /// </summary>
        public string clientNo { get; set; }
        /// <summary>
        /// 签约状态
        /// </summary>
        public string signStatus { get; set; }
        /// <summary>
        /// 冻结信息列表
        /// </summary>
        public List<corpUnInfoItem> corpUnInfo { get; set; }
        /// <summary>
        /// 对公账户控制标志
        /// </summary>
        public string cntlFlag { get; set; }
        /// <summary>
        /// 返回状态
        /// </summary>
        public string returnSt { get; set; }
        /// <summary>
        /// 签约编号
        /// </summary>
        public string signNo { get; set; }
        /// <summary>
        /// 签约状态
        /// </summary>
        public string signSt { get; set; }
        /// <summary>
        /// 交易状态
        /// </summary>
        public string tranStatus { get; set; }

    }

    /// <summary>
    /// 冻结信息详情
    /// </summary>
    public class corpUnInfoItem
    {
        /// <summary>
        /// 冻结控制编号
        /// </summary>
        public string bussId { get; set; }
        /// <summary>
        /// 帐号
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 冻结控制客户名称
        /// </summary>
        public string clientName { get; set; }
        /// <summary>
        /// 币种
        /// </summary>
        public string ccy { get; set; }
        /// <summary>
        /// 钞汇标志
        /// </summary>
        public string cashRateFlag { get; set; }
        /// <summary>
        /// 冻结控制方式代码
        /// </summary>
        public string frzFlag { get; set; }
        /// <summary>
        /// 解冻解控方式代码
        /// </summary>
        public string pcsMode { get; set; }
        /// <summary>
        /// 冻结控制生效标志
        /// </summary>
        public string confirmFlag { get; set; }
        /// <summary>
        /// 解冻解控金额
        /// </summary>
        public string unfrzAmt { get; set; }
        /// <summary>
        /// 剩余控制金额
        /// </summary>
        public string remainLimit { get; set; }
        /// <summary>
        /// 控制日期
        /// </summary>
        public string vldStrtDt { get; set; }
        /// <summary>
        /// 控制到期日
        /// </summary>
        public string expiredDate { get; set; }
        /// <summary>
        /// 解控日期
        /// </summary>
        public string unfrzDate { get; set; }
        /// <summary>
        /// 冻结控制说明
        /// </summary>
        public string cmntInfo { get; set; }
        /// <summary>
        /// 执行执法人员名称
        /// </summary>
        public string opertorName { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public string empNo { get; set; }
        /// <summary>
        /// 冻结控制联系电话
        /// </summary>
        public string telephone { get; set; }
        /// <summary>
        /// 报表路径
        /// </summary>
        public string rptPath { get; set; }

    }
}
