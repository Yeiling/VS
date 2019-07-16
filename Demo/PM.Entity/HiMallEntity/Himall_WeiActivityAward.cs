using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_WeiActivityAward
    {
           public Himall_WeiActivityAward(){


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
           public long ActivityId {get;set;}

           /// <summary>
           /// Desc:保存字段1-10 分别对应1至10等奖
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AwardLevel {get;set;}

           /// <summary>
           /// Desc:积分；红包；优惠卷
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AwardType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AwardCount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public float Proportion {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Integral {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BonusId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CouponId {get;set;}

    }
}
