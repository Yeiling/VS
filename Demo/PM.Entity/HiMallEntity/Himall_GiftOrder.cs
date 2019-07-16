using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_GiftOrder
    {
           public Himall_GiftOrder(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:订单状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int OrderStatus {get;set;}

           /// <summary>
           /// Desc:用户编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:会员留言
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserRemark {get;set;}

           /// <summary>
           /// Desc:收货人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShipTo {get;set;}

           /// <summary>
           /// Desc:收货人电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CellPhone {get;set;}

           /// <summary>
           /// Desc:一级地区
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TopRegionId {get;set;}

           /// <summary>
           /// Desc:地区编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RegionId {get;set;}

           /// <summary>
           /// Desc:地区全称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RegionFullName {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// Desc:快递公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExpressCompanyName {get;set;}

           /// <summary>
           /// Desc:快递单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShipOrderNumber {get;set;}

           /// <summary>
           /// Desc:发货时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ShippingDate {get;set;}

           /// <summary>
           /// Desc:下单时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime OrderDate {get;set;}

           /// <summary>
           /// Desc:完成时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FinishDate {get;set;}

           /// <summary>
           /// Desc:积分总价
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TotalIntegral {get;set;}

           /// <summary>
           /// Desc:关闭原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CloseReason {get;set;}

    }
}
