using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_CouponRecord
    {
           public Himall_CouponRecord(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CouponId {get;set;}

           /// <summary>
           /// Desc:优惠券的SN标示
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CounponSN {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CounponTime {get;set;}

           /// <summary>
           /// Desc:用户名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UsedTime {get;set;}

           /// <summary>
           /// Desc:使用的订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? OrderId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ShopName {get;set;}

           /// <summary>
           /// Desc:优惠券状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CounponStatus {get;set;}

           /// <summary>
           /// Desc:微信Code记录号 与微信卡券投放记录关联
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? WXCodeId {get;set;}

    }
}
