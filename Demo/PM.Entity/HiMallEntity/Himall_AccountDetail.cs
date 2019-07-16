using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_AccountDetail
    {
           public Himall_AccountDetail(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:结算记录外键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long AccountId {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShopName {get;set;}

           /// <summary>
           /// Desc:完成日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime Date {get;set;}

           /// <summary>
           /// Desc:订单下单日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime OrderDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime OrderFinshDate {get;set;}

           /// <summary>
           /// Desc:枚举 完成订单1，退订单0
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int OrderType {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderId {get;set;}

           /// <summary>
           /// Desc:订单金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal OrderAmount {get;set;}

           /// <summary>
           /// Desc:商品实付总额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal ProductActualPaidAmount {get;set;}

           /// <summary>
           /// Desc:运费金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal FreightAmount {get;set;}

           /// <summary>
           /// Desc:税费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal TaxAmount {get;set;}

           /// <summary>
           /// Desc:积分抵扣金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal IntegralDiscount {get;set;}

           /// <summary>
           /// Desc:佣金
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal CommissionAmount {get;set;}

           /// <summary>
           /// Desc:退款金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal RefundTotalAmount {get;set;}

           /// <summary>
           /// Desc:退还佣金
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal RefundCommisAmount {get;set;}

           /// <summary>
           /// Desc:退单的日期集合以;分隔
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OrderRefundsDates {get;set;}

           /// <summary>
           /// Desc:分销佣金
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal BrokerageAmount {get;set;}

           /// <summary>
           /// Desc:退分销佣金
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal ReturnBrokerageAmount {get;set;}

           /// <summary>
           /// Desc:结算金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal SettlementAmount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaymentTypeName {get;set;}

    }
}
