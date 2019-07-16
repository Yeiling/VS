using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///分销佣金表
    ///</summary>
    public partial class Himall_DistributionBrokerage
    {
           public Himall_DistributionBrokerage(){


           }
           /// <summary>
           /// Desc:流水号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:订单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderId {get;set;}

           /// <summary>
           /// Desc:订单项编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderItemId {get;set;}

           /// <summary>
           /// Desc:商品编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:下单会员
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MemberId {get;set;}

           /// <summary>
           /// Desc:店铺编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:购买数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Quantity {get;set;}

           /// <summary>
           /// Desc:实付金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal RealPayAmount {get;set;}

           /// <summary>
           /// Desc:佣金状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int BrokerageStatus {get;set;}

           /// <summary>
           /// Desc:下单时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OrderDate {get;set;}

           /// <summary>
           /// Desc:结算时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SettlementTime {get;set;}

           /// <summary>
           /// Desc:一级分销员
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SuperiorId1 {get;set;}

           /// <summary>
           /// Desc:一级分佣比
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal BrokerageRate1 {get;set;}

           /// <summary>
           /// Desc:二级分销员
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SuperiorId2 {get;set;}

           /// <summary>
           /// Desc:二级分佣比
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal BrokerageRate2 {get;set;}

           /// <summary>
           /// Desc:三级分销员
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SuperiorId3 {get;set;}

           /// <summary>
           /// Desc:三级分佣比
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal BrokerageRate3 {get;set;}

    }
}
