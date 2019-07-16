using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///分销默认佣金比例表
    ///</summary>
    public partial class Himall_DistributionShopRateConfig
    {
           public Himall_DistributionShopRateConfig(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:店铺编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

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

    }
}
