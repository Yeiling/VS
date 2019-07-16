using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_GiftOrderItem
    {
           public Himall_GiftOrderItem(){


           }
           /// <summary>
           /// Desc:编号
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
           /// Desc:礼品编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long GiftId {get;set;}

           /// <summary>
           /// Desc:数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Quantity {get;set;}

           /// <summary>
           /// Desc:积分单价
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int SaleIntegral {get;set;}

           /// <summary>
           /// Desc:礼品名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GiftName {get;set;}

           /// <summary>
           /// Desc:礼品价值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal GiftValue {get;set;}

           /// <summary>
           /// Desc:图片存放地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ImagePath {get;set;}

    }
}
