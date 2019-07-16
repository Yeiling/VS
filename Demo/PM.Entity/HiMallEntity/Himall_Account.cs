using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Account
    {
           public Himall_Account(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:店铺名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ShopName {get;set;}

           /// <summary>
           /// Desc:出账日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime AccountDate {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime StartDate {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EndDate {get;set;}

           /// <summary>
           /// Desc:枚举 0未结账，1已结账
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:商品实付总额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal ProductActualPaidAmount {get;set;}

           /// <summary>
           /// Desc:运费
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal FreightAmount {get;set;}

           /// <summary>
           /// Desc:佣金
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal CommissionAmount {get;set;}

           /// <summary>
           /// Desc:退还佣金
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal RefundCommissionAmount {get;set;}

           /// <summary>
           /// Desc:退款金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal RefundAmount {get;set;}

           /// <summary>
           /// Desc:预付款总额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal AdvancePaymentAmount {get;set;}

           /// <summary>
           /// Desc:本期应结
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal PeriodSettlement {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:分销佣金
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal Brokerage {get;set;}

           /// <summary>
           /// Desc:退还分销佣金
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal ReturnBrokerage {get;set;}

    }
}
