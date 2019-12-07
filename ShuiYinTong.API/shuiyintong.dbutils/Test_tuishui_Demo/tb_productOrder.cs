using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///订单表
    ///</summary>
    [SugarTable("tb_productOrder")]
    public partial class tb_productOrder
    {
           public tb_productOrder(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:产品ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? pId {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? uId {get;set;}

           /// <summary>
           /// Desc:借款
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? lendMoney {get;set;}

           /// <summary>
           /// Desc:还款
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? returnMoney {get;set;}

           /// <summary>
           /// Desc:申请年月
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string returndata {get;set;}

           /// <summary>
           /// Desc:年利率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? minRate {get;set;}

           /// <summary>
           /// Desc:借款期限
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? dateline {get;set;}

           /// <summary>
           /// Desc:申请日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? pubDate {get;set;}

           /// <summary>
           /// Desc:信用额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? creditTotal {get;set;}

           /// <summary>
           /// Desc:审批金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? approveTotal {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? mId {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userManager {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderNo {get;set;}

           /// <summary>
           /// Desc:还款方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string returnWay {get;set;}

           /// <summary>
           /// Desc:批次
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string returnPC {get;set;}

           /// <summary>
           /// Desc:申报流程实例ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LCSLID {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string pdfFile {get;set;}

           /// <summary>
           /// Desc:用款金额
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? needTotal {get;set;}

           /// <summary>
           /// Desc:授信期限开始
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SXbeginDate {get;set;}

           /// <summary>
           /// Desc:授信期限结束
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SXendDate {get;set;}

           /// <summary>
           /// Desc:自动测算评级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string autoPJ {get;set;}

           /// <summary>
           /// Desc:确认评级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string confirmPJ {get;set;}

           /// <summary>
           /// Desc:自动测算额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? autoEDu {get;set;}

           /// <summary>
           /// Desc:担保公司ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? guaranteeId {get;set;}

           /// <summary>
           /// Desc:担保额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? guaranteeEdu {get;set;}

           /// <summary>
           /// Desc:担保评级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string guaranteePJ {get;set;}

           /// <summary>
           /// Desc:担保自动测算额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? guaranteeEduAuto {get;set;}

           /// <summary>
           /// Desc:担保自动测算评级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string guaranteePJAuto {get;set;}

           /// <summary>
           /// Desc:授信期限开始
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string guaranteeSXbeginDate {get;set;}

           /// <summary>
           /// Desc:授信期限结束
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string guaranteeSXendDate {get;set;}

           /// <summary>
           /// Desc:年退税额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? yearTSE {get;set;}

           /// <summary>
           /// Desc:征信情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXQK {get;set;}

           /// <summary>
           /// Desc:企业贷款余额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? companyDKYE {get;set;}

           /// <summary>
           /// Desc:经营贷款余额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? JYDKYE {get;set;}

           /// <summary>
           /// Desc:营业收入
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? YYSR {get;set;}

           /// <summary>
           /// Desc:企业退税评级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string rating {get;set;}

           /// <summary>
           /// Desc:银行征信情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankZXQK {get;set;}

           /// <summary>
           /// Desc:初审说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ChuShenInfo {get;set;}

           /// <summary>
           /// Desc:复审说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FuShenInfo {get;set;}

           /// <summary>
           /// Desc:税银通ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:准入模型决策结果	
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string zrResult {get;set;}

           /// <summary>
           /// Desc:授信模型结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? sxEDU {get;set;}

           /// <summary>
           /// Desc:评估模型结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string zrPGResult {get;set;}

           /// <summary>
           /// Desc:准入时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? zrDate {get;set;}

           /// <summary>
           /// Desc:担授合同编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bhNo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updates {get;set;}

           /// <summary>
           /// Desc:订单更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updatetime {get;set;}

           /// <summary>
           /// Desc:初审生成报告时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? csReportDate {get;set;}

           /// <summary>
           /// Desc:复审生成报告时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? fsReportDate {get;set;}

           /// <summary>
           /// Desc:准入分数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string zrScore {get;set;}

           /// <summary>
           /// Desc:需要系统后台操作 1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string systemflag {get;set;}

           /// <summary>
           /// Desc:准入更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? zrupdate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? zrcsuptime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? zrfsuptime {get;set;}

           /// <summary>
           /// Desc:历史逾期标志 1-历史逾期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string historyYuQi {get;set;}

    }
}
