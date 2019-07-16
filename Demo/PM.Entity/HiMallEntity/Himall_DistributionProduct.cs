using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///分销商品表
    ///</summary>
    public partial class Himall_DistributionProduct
    {
           public Himall_DistributionProduct(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:商品编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:店铺编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:商品分销状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ProductStatus {get;set;}

           /// <summary>
           /// Desc:一级分佣比
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal BrokerageRate1 {get;set;}

           /// <summary>
           /// Desc:二级分佣比
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal BrokerageRate2 {get;set;}

           /// <summary>
           /// Desc:三级分佣比
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal BrokerageRate3 {get;set;}

           /// <summary>
           /// Desc:成交件数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SaleCount {get;set;}

           /// <summary>
           /// Desc:成交金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal SaleAmount {get;set;}

           /// <summary>
           /// Desc:已结算金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal SettlementAmount {get;set;}

           /// <summary>
           /// Desc:添加推广时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AddDate {get;set;}

    }
}
