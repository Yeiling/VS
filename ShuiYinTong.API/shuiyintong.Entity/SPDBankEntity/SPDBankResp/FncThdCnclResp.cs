using shuiyintong.Entity.SPDBankEntity.SPDBankResp;
using System.Collections.Generic;

namespace shuiyintong.Entity.SPDBankEntity.SPDResp
{
    /// <summary>
    /// 三方解约返回类型
    /// </summary>
    public class FncThdCnclResp : BaseResp
    {
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
        /// 对公账户控制标志 0-成功 1-失败 2-已解控
        /// </summary>
        public string cntlFlag { get; set; }
        /// <summary>
        /// 返回状态 0-成功 1-失败 2-已解约
        /// </summary>
        public string returnSt { get; set; }
        /// <summary>
        /// 签约编号
        /// </summary>
        public string signNo { get; set; }
        /// <summary>
        /// 签约状态 0-成功 1-失败 2-已解约
        /// </summary>
        public string signSt { get; set; }
        /// <summary>
        /// 交易状态0-成功 1-失败 2-已解约
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
        /// 币种29-澳大利亚元 28-加拿大元 22-丹麦克郎 38-欧元 99-全币种 12-英镑 13-港币 23-挪威克郎 01-人民币 21-瑞典克郎 18-新加坡元 15-瑞士法郎 14-美元 27-日元
        /// </summary>
        public string ccy { get; set; }
        /// <summary>
        /// 钞汇标志0-钞户 1-汇户
        /// </summary>
        public string cashRateFlag { get; set; }
        /// <summary>
        /// 冻结控制方式代码 0-金额 1-只进不出 2-不进不出
        /// </summary>
        public string frzFlag { get; set; }
        /// <summary>
        /// 解冻解控方式代码 1-部分  2-全部
        /// </summary>
        public string pcsMode { get; set; }
        /// <summary>
        /// 冻结控制生效标志0-生效 1-轮候  2-失效 3-部分生效
        /// </summary>
        public string confirmFlag { get; set; }
        /// <summary>
        /// 解冻解控金额 精确到两位有效数字eg:100.00
        /// </summary>
        public string unfrzAmt { get; set; }
        /// <summary>
        /// 剩余控制金额 精确到两位有效数字eg:100.00
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
