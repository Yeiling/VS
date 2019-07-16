using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///注册送优惠券关联优惠券
    ///</summary>
    public partial class Himall_CouponSendByRegisterDetailed
    {
           public Himall_CouponSendByRegisterDetailed(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:注册活动ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CouponRegisterId {get;set;}

           /// <summary>
           /// Desc:优惠券ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CouponId {get;set;}

    }
}
