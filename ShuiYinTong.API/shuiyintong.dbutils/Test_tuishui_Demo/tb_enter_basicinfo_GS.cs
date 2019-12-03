using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_enter_basicinfo_GS")]
    public partial class tb_enter_basicinfo_GS
    {
           public tb_enter_basicinfo_GS(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:税银通企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

           /// <summary>
           /// Desc:法人个人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FRSYT_PER_Id {get;set;}

           /// <summary>
           /// Desc:预计申请开立保函日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExceptBaohanDate {get;set;}

           /// <summary>
           /// Desc:当期财报年份
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Finanalyear {get;set;}

           /// <summary>
           /// Desc:期望保函额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ExceptBaohanEdu {get;set;}

           /// <summary>
           /// Desc:企业当期年度净利润
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? YearProfit {get;set;}

           /// <summary>
           /// Desc:合作银行支行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Bankbranch {get;set;}

           /// <summary>
           /// Desc:企业上期年度净利润
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LastYearProfit {get;set;}

           /// <summary>
           /// Desc:银行客户经理姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankManagerName {get;set;}

           /// <summary>
           /// Desc:企业当期年度负债合计
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? YearDebt {get;set;}

           /// <summary>
           /// Desc:企业进/出口业务年限
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BusinessTerm {get;set;}

           /// <summary>
           /// Desc:企业上期年度负债合计
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LastYearDebt {get;set;}

           /// <summary>
           /// Desc:企业纳税人状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string companyStatus {get;set;}

           /// <summary>
           /// Desc:企业当期年度资产合计
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? YearCapital {get;set;}

           /// <summary>
           /// Desc:企业纳税信用等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxLevel {get;set;}

           /// <summary>
           /// Desc:企业上期年度资产合计
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LastYearCapital {get;set;}

           /// <summary>
           /// Desc:企业海关信用等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BusinessLevel {get;set;}

           /// <summary>
           /// Desc:企业是否存在税务违法情形
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxIllegal {get;set;}

           /// <summary>
           /// Desc:企业欠缴关税记录数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OwingTaxCount {get;set;}

           /// <summary>
           /// Desc:企业上年度进口纳税金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LastYearImportTaxAmt {get;set;}

           /// <summary>
           /// Desc:企业实际控制人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ControllerName {get;set;}

           /// <summary>
           /// Desc:企业最近三年是否存在人行征信不良信用记录
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyExistBad {get;set;}

           /// <summary>
           /// Desc:企业实际控制人身份证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ControllerIDNo {get;set;}

           /// <summary>
           /// Desc:企业关键人最近三年是否存在人行征信不良信用记录
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PerExistBad {get;set;}

           /// <summary>
           /// Desc:企业实际控制人手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ControllerTel {get;set;}

           /// <summary>
           /// Desc:关键人征信不良人员类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PerExistBadType {get;set;}

           /// <summary>
           /// Desc:临时保存falg  临时0  正式1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? TempStatus {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updateTime {get;set;}

           /// <summary>
           /// Desc:授信订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? OrderId {get;set;}

    }
}
