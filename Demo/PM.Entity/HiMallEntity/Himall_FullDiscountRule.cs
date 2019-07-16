using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///满减规则
    ///</summary>
    public partial class Himall_FullDiscountRule
    {
           public Himall_FullDiscountRule(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:活动编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ActiveId {get;set;}

           /// <summary>
           /// Desc:条件
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Quota {get;set;}

           /// <summary>
           /// Desc:优惠
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Discount {get;set;}

    }
}
