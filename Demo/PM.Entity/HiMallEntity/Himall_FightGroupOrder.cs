using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///拼团订单
    ///</summary>
    public partial class Himall_FightGroupOrder
    {
           public Himall_FightGroupOrder(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:对应活动
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ActiveId {get;set;}

           /// <summary>
           /// Desc:对应商品
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
           /// Desc:所属拼团
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long GroupId {get;set;}

           /// <summary>
           /// Desc:订单时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderId {get;set;}

           /// <summary>
           /// Desc:订单用户编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderUserId {get;set;}

           /// <summary>
           /// Desc:是否团首订单
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsFirstOrder {get;set;}

           /// <summary>
           /// Desc:参团时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime JoinTime {get;set;}

           /// <summary>
           /// Desc:参团状态 参团中  成功  失败
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int JoinStatus {get;set;}

           /// <summary>
           /// Desc:结束时间 成功或失败的时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OverTime {get;set;}

           /// <summary>
           /// Desc:购买数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Quantity {get;set;}

           /// <summary>
           /// Desc:销售价
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal SalePrice {get;set;}

    }
}
