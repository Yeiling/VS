using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_CouponSetting
    {
           public Himall_CouponSetting(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:优惠券的发行平台
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int PlatForm {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CouponID {get;set;}

           /// <summary>
           /// Desc:是否显示
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Display {get;set;}

    }
}
