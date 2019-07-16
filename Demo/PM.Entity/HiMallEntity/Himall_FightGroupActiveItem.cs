using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///拼团活动项
    ///</summary>
    public partial class Himall_FightGroupActiveItem
    {
           public Himall_FightGroupActiveItem(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:所属活动
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ActiveId {get;set;}

           /// <summary>
           /// Desc:商品编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:商品SKU
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SkuId {get;set;}

           /// <summary>
           /// Desc:活动售价
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal ActivePrice {get;set;}

           /// <summary>
           /// Desc:活动库存
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ActiveStock {get;set;}

           /// <summary>
           /// Desc:已售
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BuyCount {get;set;}

    }
}
