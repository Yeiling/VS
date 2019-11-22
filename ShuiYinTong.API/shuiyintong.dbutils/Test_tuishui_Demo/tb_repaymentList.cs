using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///还款计划表
    ///</summary>
    [SugarTable("tb_repaymentList")]
    public partial class tb_repaymentList
    {
           public tb_repaymentList(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string orderId {get;set;}

           /// <summary>
           /// Desc:利率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? minRate {get;set;}

           /// <summary>
           /// Desc:期限
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? dateline {get;set;}

           /// <summary>
           /// Desc:订单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderNo {get;set;}

           /// <summary>
           /// Desc:产品ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? pId {get;set;}

           /// <summary>
           /// Desc:开始日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? beginDate {get;set;}

           /// <summary>
           /// Desc:结束日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? endDate {get;set;}

           /// <summary>
           /// Desc:本金
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? needTotal {get;set;}

           /// <summary>
           /// Desc:应还金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? planPay {get;set;}

           /// <summary>
           /// Desc:0-未逾期 1-已逾期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string overdue {get;set;}

           /// <summary>
           /// Desc:还款日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? payDate {get;set;}

           /// <summary>
           /// Desc:0 未还款  1-已还款银行未确认  2-已还款银行已确认
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status {get;set;}

           /// <summary>
           /// Desc:实际还款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? actualPay {get;set;}

           /// <summary>
           /// Desc:计划利息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? planInterest {get;set;}

           /// <summary>
           /// Desc:实际利息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? actualInterest {get;set;}

           /// <summary>
           /// Desc:技术服务费-预估
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? serviceRate_yugu {get;set;}

           /// <summary>
           /// Desc:技术服务费-实收
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? serviceRate_shishou {get;set;}

           /// <summary>
           /// Desc:收入时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? incomeTime {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remarks {get;set;}

    }
}
